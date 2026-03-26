namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private readonly Stack<CalculatorState> _history = new();
        private decimal _currentResult;
        private string? _pendingOperator;
        private bool _isNewInput = true;

        private record CalculatorState(decimal CurrentResult, string? PendingOperator, bool IsNewInput, string InputText, string ResultText);

        public Form1()
        {
            InitializeComponent();
            WireEvents();
            ResetCalculator();
        }

        private void WireEvents()
        {
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;

            btnAdd.Click += OperatorButton_Click;
            btnSub.Click += OperatorButton_Click;
            btnMul.Click += OperatorButton_Click;
            btnDiv.Click += OperatorButton_Click;

            btnEqual.Click += BtnEqual_Click;
            btnDot.Click += BtnDot_Click;
            btnSign.Click += BtnSign_Click;
            btnBS.Click += BtnBS_Click;
            btnCE.Click += BtnCE_Click;
            btnC.Click += BtnC_Click;
            btnPer.Click += BtnPer_Click;
            btnReci.Click += BtnReci_Click;
            btnSq.Click += BtnSq_Click;
            btnLoot.Click += BtnLoot_Click;
        }

        private void NumberButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (_isNewInput || txtInput.Text == "0")
            {
                txtInput.Text = button.Text;
            }
            else
            {
                txtInput.Text += button.Text;
            }

            _isNewInput = false;
        }

        private void BtnDot_Click(object? sender, EventArgs e)
        {
            if (_isNewInput)
            {
                txtInput.Text = "0.";
                _isNewInput = false;
                return;
            }

            if (!txtInput.Text.Contains('.'))
            {
                txtInput.Text += ".";
            }
        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button || !TryGetInputValue(out var inputValue))
            {
                return;
            }

            if (_pendingOperator is null)
            {
                _currentResult = inputValue;
                txtResult.Text = $"{FormatNumber(inputValue)} {NormalizeOperator(button.Text)} ";
            }
            else
            {
                SaveState();
                _currentResult = ApplyBinaryOperation(_currentResult, inputValue, _pendingOperator);
                txtResult.Text += $"{FormatNumber(inputValue)} {NormalizeOperator(button.Text)} ";
            }

            _pendingOperator = button.Text;
            _isNewInput = true;
        }

        private void BtnEqual_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputValue(out var inputValue))
            {
                return;
            }

            if (_pendingOperator is null)
            {
                _currentResult = inputValue;
                txtResult.Text = FormatNumber(_currentResult);
            }
            else
            {
                SaveState();
                _currentResult = ApplyBinaryOperation(_currentResult, inputValue, _pendingOperator);
                txtResult.Text = $"{txtResult.Text}{FormatNumber(inputValue)} = {FormatNumber(_currentResult)}";
            }

            txtInput.Text = FormatNumber(_currentResult);
            _pendingOperator = null;
            _isNewInput = true;
        }

        private void BtnSign_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputValue(out var inputValue) || inputValue == 0)
            {
                return;
            }

            inputValue *= -1;
            txtInput.Text = FormatNumber(inputValue);
            _isNewInput = false;
        }

        private void BtnBS_Click(object? sender, EventArgs e)
        {
            if (_isNewInput)
            {
                return;
            }

            if (txtInput.Text.Length <= 1 || (txtInput.Text.Length == 2 && txtInput.Text.StartsWith('-')))
            {
                txtInput.Text = "0";
                return;
            }

            txtInput.Text = txtInput.Text[..^1];
        }

        private void BtnCE_Click(object? sender, EventArgs e)
        {
            txtInput.Text = "0";
            _isNewInput = true;
        }

        private void BtnC_Click(object? sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void BtnPer_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputValue(out var inputValue))
            {
                return;
            }

            inputValue /= 100m;
            txtInput.Text = FormatNumber(inputValue);
            _isNewInput = false;
        }

        private void BtnReci_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputValue(out var inputValue) || inputValue == 0)
            {
                return;
            }

            inputValue = 1m / inputValue;
            txtInput.Text = FormatNumber(inputValue);
            _isNewInput = false;
        }

        private void BtnSq_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputValue(out var inputValue))
            {
                return;
            }

            inputValue *= inputValue;
            txtInput.Text = FormatNumber(inputValue);
            _isNewInput = false;
        }

        private void BtnLoot_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputValue(out var inputValue) || inputValue < 0)
            {
                return;
            }

            var sqrt = (decimal)Math.Sqrt((double)inputValue);
            txtInput.Text = FormatNumber(sqrt);
            _isNewInput = false;
        }

        private decimal ApplyBinaryOperation(decimal left, decimal right, string op)
        {
            return op switch
            {
                "＋" or "+" => left + right,
                "－" or "-" => left - right,
                "×" or "*" => left * right,
                "÷" or "/" when right != 0 => left / right,
                _ => left
            };
        }

        private void SaveState()
        {
            _history.Push(new CalculatorState(_currentResult, _pendingOperator, _isNewInput, txtInput.Text, txtResult.Text));
        }

        private void UndoLastOperation()
        {
            if (_history.Count == 0)
            {
                return;
            }

            var previous = _history.Pop();
            _currentResult = previous.CurrentResult;
            _pendingOperator = previous.PendingOperator;
            _isNewInput = previous.IsNewInput;
            txtInput.Text = previous.InputText;
            txtResult.Text = previous.ResultText;
        }

        private string BuildExpression(decimal left, string op, decimal right, decimal result)
        {
            return $"{FormatNumber(left)} {NormalizeOperator(op)} {FormatNumber(right)} = {FormatNumber(result)}";
        }

        private static string NormalizeOperator(string op)
        {
            return op switch
            {
                "＋" => "+",
                "－" => "-",
                "×" => "x",
                "÷" => "/",
                _ => op
            };
        }

        private bool TryGetInputValue(out decimal value)
        {
            return decimal.TryParse(txtInput.Text, out value);
        }

        private static string FormatNumber(decimal value)
        {
            return value.ToString("0.###########");
        }

        private void ResetCalculator()
        {
            _history.Clear();
            _currentResult = 0;
            _pendingOperator = null;
            _isNewInput = true;
            txtInput.Text = "0";
            txtResult.Text = "0";
        }

    }
}
