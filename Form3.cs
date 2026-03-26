namespace SimpleCalculator
{
    public partial class Form3 : Form
    {
        private readonly Action<string> _onOperatorClick;

        public Form3(Action<string> onOperatorClick)
        {
            _onOperatorClick = onOperatorClick;
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnOpenParen.Click += OperatorButton_Click;
            btnCloseParen.Click += OperatorButton_Click;
            btnAbs.Click += OperatorButton_Click;
            btnPi.Click += OperatorButton_Click;
            btnLog.Click += OperatorButton_Click;
            btnLn.Click += OperatorButton_Click;
            btnExp.Click += OperatorButton_Click;
            btnMod.Click += OperatorButton_Click;
        }

        private void OperatorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            _onOperatorClick(button.Text);
        }
    }
}
