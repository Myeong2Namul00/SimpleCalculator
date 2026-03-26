namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private const string DivideByZeroMessage = "0으로 나눌 수 없습니다!";
        private static readonly System.Text.RegularExpressions.Regex ValidNumberRegex = new(@"^-?\d*(\.\d*)?$", System.Text.RegularExpressions.RegexOptions.Compiled);
        private static readonly System.Text.RegularExpressions.Regex ValidExpressionRegex = new(@"^[0-9+\-x*/().%mod\s]*$", System.Text.RegularExpressions.RegexOptions.Compiled);

        private readonly Stack<CalculatorState> _history = new();
        private readonly List<string> _calculationHistory = new();
        private decimal _currentResult;
        private string? _pendingOperator;
        private bool _isNewInput = true;
        private bool _isExpressionMode;
        private bool _isInternalInputUpdate;
        private string _lastValidInputText = "0";
        private Form2? _historyForm;
        private Form3? _expandForm;

        private record CalculatorState(decimal CurrentResult, string? PendingOperator, bool IsNewInput, string InputText, string ResultText);

        public Form1()
        {
            InitializeComponent();
            FormMoveSyncManager.Register(this);
            KeyPreview = true;
            WireEvents();
            ResetCalculator();
        }

        private void WireEvents()
        {
            KeyDown += Form1_KeyDown;
            txtInput.KeyPress += TxtInput_KeyPress;
            txtInput.TextChanged += TxtInput_TextChanged;
            txtResult.ReadOnly = true;

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
            btnHistory.Click += BtnHistory_Click;
            btnExpand.Click += BtnExpand_Click;
        }

        private void TxtInput_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            var currentText = txtInput.Text;
            var nextText = currentText.Remove(txtInput.SelectionStart, txtInput.SelectionLength)
                .Insert(txtInput.SelectionStart, e.KeyChar.ToString());

            if (!IsValidInputText(nextText))
            {
                e.Handled = true;
            }
        }

        private void TxtInput_TextChanged(object? sender, EventArgs e)
        {
            if (_isInternalInputUpdate)
            {
                return;
            }

            if (IsValidInputText(txtInput.Text))
            {
                _lastValidInputText = txtInput.Text;
                return;
            }

            _isInternalInputUpdate = true;
            txtInput.Text = _lastValidInputText;
            txtInput.SelectionStart = txtInput.Text.Length;
            _isInternalInputUpdate = false;
        }

        private bool IsValidInputText(string text)
        {
            if (text == DivideByZeroMessage)
            {
                return true;
            }

            if (_isExpressionMode)
            {
                return ValidExpressionRegex.IsMatch(text);
            }

            return string.IsNullOrEmpty(text) || ValidNumberRegex.IsMatch(text);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            var handled = true;

            if (e.Shift && e.KeyCode == Keys.D9)
            {
                HandleExpandedOperator("(");
            }
            else if (e.Shift && e.KeyCode == Keys.D0)
            {
                HandleExpandedOperator(")");
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                    case Keys.NumPad0:
                        btn0.PerformClick();
                        break;
                    case Keys.D1:
                    case Keys.NumPad1:
                        btn1.PerformClick();
                        break;
                    case Keys.D2:
                    case Keys.NumPad2:
                        btn2.PerformClick();
                        break;
                    case Keys.D3:
                    case Keys.NumPad3:
                        btn3.PerformClick();
                        break;
                    case Keys.D4:
                    case Keys.NumPad4:
                        btn4.PerformClick();
                        break;
                    case Keys.D5:
                    case Keys.NumPad5:
                        if (e.Shift)
                        {
                            btnPer.PerformClick();
                        }
                        else
                        {
                            btn5.PerformClick();
                        }
                        break;
                    case Keys.D6:
                    case Keys.NumPad6:
                        btn6.PerformClick();
                        break;
                    case Keys.D7:
                    case Keys.NumPad7:
                        btn7.PerformClick();
                        break;
                    case Keys.D8:
                    case Keys.NumPad8:
                        if (e.Shift)
                        {
                            btnMul.PerformClick();
                        }
                        else
                        {
                            btn8.PerformClick();
                        }
                        break;
                    case Keys.D9:
                    case Keys.NumPad9:
                        btn9.PerformClick();
                        break;
                    case Keys.Decimal:
                    case Keys.OemPeriod:
                        btnDot.PerformClick();
                        break;
                    case Keys.Add:
                    case Keys.Oemplus:
                        if (e.Shift)
                        {
                            btnAdd.PerformClick();
                        }
                        else
                        {
                            btnEqual.PerformClick();
                        }
                        break;
                    case Keys.Subtract:
                    case Keys.OemMinus:
                        btnSub.PerformClick();
                        break;
                    case Keys.X:
                    case Keys.Multiply:
                        btnMul.PerformClick();
                        break;
                    case Keys.Divide:
                    case Keys.Oem2:
                        btnDiv.PerformClick();
                        break;
                    case Keys.M:
                        HandleExpandedOperator("mod");
                        break;
                    case Keys.Back:
                        btnBS.PerformClick();
                        break;
                    case Keys.Delete:
                        btnCE.PerformClick();
                        break;
                    case Keys.C when !e.Control && !e.Alt:
                        btnCE.PerformClick();
                        break;
                    case Keys.Escape:
                        btnC.PerformClick();
                        break;
                    case Keys.Enter:
                        btnEqual.PerformClick();
                        break;
                    default:
                        handled = false;
                        break;
                }
            }

            if (handled)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void NumberButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (_isExpressionMode)
            {
                if (txtInput.Text == "0")
                {
                    txtInput.Text = button.Text;
                }
                else
                {
                    txtInput.Text += button.Text;
                }

                _isNewInput = false;
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
            if (_isExpressionMode)
            {
                txtInput.Text += ".";
                _isNewInput = false;
                return;
            }

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
            if (sender is not Button button)
            {
                return;
            }

            if (_isExpressionMode)
            {
                txtInput.Text += NormalizeOperator(button.Text);
                _isNewInput = false;
                return;
            }

            if (!TryGetInputValue(out var inputValue))
            {
                return;
            }

            ApplyOperator(inputValue, button.Text);
        }

        private void ApplyOperator(decimal inputValue, string operatorText)
        {
            try
            {
                if (_pendingOperator is null)
                {
                    _currentResult = inputValue;
                    txtResult.Text = $"{FormatNumber(inputValue)} {NormalizeOperator(operatorText)} ";
                }
                else
                {
                    SaveState();
                    _currentResult = ApplyBinaryOperation(_currentResult, inputValue, _pendingOperator);
                    txtResult.Text += $"{FormatNumber(inputValue)} {NormalizeOperator(operatorText)} ";
                }

                _pendingOperator = operatorText;
                _isNewInput = true;
            }
            catch (DivideByZeroException)
            {
                ShowInputError(DivideByZeroMessage);
            }
        }

        private void BtnEqual_Click(object? sender, EventArgs e)
        {
            if (_isExpressionMode)
            {
                if (!TryEvaluateExpression(txtInput.Text, out var expressionResult))
                {
                    return;
                }

                var expression = $"{txtInput.Text} = {FormatNumber(expressionResult)}";
                txtResult.Text = expression;
                txtInput.Text = FormatNumber(expressionResult);
                _calculationHistory.Add(expression);
                _historyForm?.RefreshHistory();
                _currentResult = expressionResult;
                _pendingOperator = null;
                _isNewInput = true;
                _isExpressionMode = false;
                return;
            }

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
                try
                {
                    SaveState();
                    _currentResult = ApplyBinaryOperation(_currentResult, inputValue, _pendingOperator);
                    var expression = $"{txtResult.Text}{FormatNumber(inputValue)} = {FormatNumber(_currentResult)}";
                    txtResult.Text = expression;
                    _calculationHistory.Add(expression);
                    _historyForm?.RefreshHistory();
                }
                catch (DivideByZeroException)
                {
                    ShowInputError(DivideByZeroMessage);
                    return;
                }
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
            ResetCalculator();
        }

        private void BtnCE_Click(object? sender, EventArgs e)
        {
            txtInput.Text = "0";
            _isNewInput = true;
            _isExpressionMode = false;
        }

        private void BtnC_Click(object? sender, EventArgs e)
        {
            ResetCalculator();
        }

        private void BtnHistory_Click(object? sender, EventArgs e)
        {
            if (_historyForm is null || _historyForm.IsDisposed)
            {
                _historyForm = new Form2(_calculationHistory, LoadHistoryToCalculator);
                _historyForm.FormClosed += (_, _) => _historyForm = null;
            }

            _historyForm.StartPosition = FormStartPosition.Manual;
            _historyForm.Location = new Point(Right, Top);
            _historyForm.RefreshHistory();
            _historyForm.Show();
            _historyForm.BringToFront();
        }

        private void BtnExpand_Click(object? sender, EventArgs e)
        {
            if (_expandForm is null || _expandForm.IsDisposed)
            {
                _expandForm = new Form3(HandleExpandedOperator);
                _expandForm.FormClosed += (_, _) => _expandForm = null;
            }

            _expandForm.StartPosition = FormStartPosition.Manual;
            _expandForm.Location = new Point(Left, Bottom);
            _expandForm.Show();
            _expandForm.BringToFront();
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
            if (!TryGetInputValue(out var inputValue))
            {
                return;
            }

            if (inputValue == 0)
            {
                ShowInputError(DivideByZeroMessage);
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
                "÷" or "/" when right == 0 => throw new DivideByZeroException(),
                "÷" or "/" => left / right,
                "mod" when right == 0 => throw new DivideByZeroException(),
                "mod" => left % right,
                _ => left
            };
        }

        private void HandleExpandedOperator(string op)
        {
            if (op == "(")
            {
                BeginOrAppendParenthesis();
                return;
            }

            if (op == ")")
            {
                if (!_isExpressionMode)
                {
                    return;
                }

                txtInput.Text += ")";
                _isNewInput = false;

                return;
            }

            if (!TryGetInputValue(out var inputValue))
            {
                return;
            }

            switch (op)
            {
                case "mod":
                    ApplyOperator(inputValue, "mod");
                    break;
                case "π":
                    txtInput.Text = FormatNumber((decimal)Math.PI);
                    _isNewInput = false;
                    break;
                case "|x|":
                    txtInput.Text = FormatNumber(Math.Abs(inputValue));
                    _isNewInput = false;
                    break;
                case "log":
                    if (inputValue <= 0)
                    {
                        return;
                    }

                    txtInput.Text = FormatNumber((decimal)Math.Log10((double)inputValue));
                    _isNewInput = false;
                    break;
                case "ln":
                    if (inputValue <= 0)
                    {
                        return;
                    }

                    txtInput.Text = FormatNumber((decimal)Math.Log((double)inputValue));
                    _isNewInput = false;
                    break;
                case "exp":
                    txtInput.Text = FormatNumber((decimal)Math.Exp((double)inputValue));
                    _isNewInput = false;
                    break;
                case "sin":
                    txtInput.Text = FormatNumber((decimal)Math.Sin(ToRadians(inputValue)));
                    _isNewInput = false;
                    break;
                case "cos":
                    txtInput.Text = FormatNumber((decimal)Math.Cos(ToRadians(inputValue)));
                    _isNewInput = false;
                    break;
                case "tan":
                    txtInput.Text = FormatNumber((decimal)Math.Tan(ToRadians(inputValue)));
                    _isNewInput = false;
                    break;
            }
        }

        private void ShowInputError(string message)
        {
            txtInput.Text = message;
            _lastValidInputText = message;
            _pendingOperator = null;
            _isNewInput = true;
            _isExpressionMode = false;
        }

        private static double ToRadians(decimal degree)
        {
            return (double)degree * Math.PI / 180d;
        }

        private void BeginOrAppendParenthesis()
        {
            if (_isExpressionMode)
            {
                txtInput.Text += "(";
                _isNewInput = false;
                return;
            }

            var expressionPrefix = BuildExpressionPrefix();
            txtInput.Text = string.IsNullOrEmpty(expressionPrefix) ? "(" : $"{expressionPrefix}(";
            _isExpressionMode = true;
            _pendingOperator = null;
            _isNewInput = false;
        }

        private string BuildExpressionPrefix()
        {
            if (_pendingOperator is not null)
            {
                return $"{FormatNumber(_currentResult)}{NormalizeOperator(_pendingOperator)}";
            }

            if (TryGetInputValue(out var inputValue) && inputValue != 0)
            {
                return FormatNumber(inputValue);
            }

            return string.Empty;
        }

        private static bool TryEvaluateExpression(string expression, out decimal result)
        {
            result = 0;

            if (string.IsNullOrWhiteSpace(expression))
            {
                return false;
            }

            var normalized = expression
                .Replace("x", "*")
                .Replace("×", "*")
                .Replace("÷", "/")
                .Replace("mod", "%")
                .Replace(" ", string.Empty);

            normalized = NormalizeImplicitMultiplication(normalized);

            try
            {
                var table = new System.Data.DataTable();
                var computed = table.Compute(normalized, null);

                if (computed is null)
                {
                    return false;
                }

                result = Convert.ToDecimal(computed);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static string NormalizeImplicitMultiplication(string expression)
        {
            var withParenMultiplier = System.Text.RegularExpressions.Regex.Replace(
                expression,
                @"(?<=[0-9\)])\(",
                "*(");

            var withRightParenMultiplier = System.Text.RegularExpressions.Regex.Replace(
                withParenMultiplier,
                @"\)(?=[0-9])",
                ")*");

            return withRightParenMultiplier;
        }

        private void LoadHistoryToCalculator(string expression)
        {
            txtResult.Text = expression;

            if (!TryExtractResultValue(expression, out var value))
            {
                return;
            }

            _currentResult = value;
            _pendingOperator = null;
            _isNewInput = true;
            txtInput.Text = FormatNumber(value);
        }

        private static bool TryExtractResultValue(string expression, out decimal value)
        {
            value = 0;
            var equalIndex = expression.LastIndexOf('=');

            if (equalIndex < 0 || equalIndex >= expression.Length - 1)
            {
                return false;
            }

            var resultText = expression[(equalIndex + 1)..].Trim();
            return decimal.TryParse(resultText, out value);
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
                "mod" => "mod",
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
            _isExpressionMode = false;
            txtInput.Text = "0";
            _lastValidInputText = "0";
            txtResult.Text = "0";
        }
    }
}
