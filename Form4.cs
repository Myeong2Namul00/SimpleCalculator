namespace SimpleCalculator
{
    public partial class Form4 : Form
    {
        private readonly Action<string> _onOperatorClick;

        public Form4(Action<string> onOperatorClick)
        {
            _onOperatorClick = onOperatorClick;
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnSin.Click += TrigButton_Click;
            btnCos.Click += TrigButton_Click;
            btnTan.Click += TrigButton_Click;
        }

        private void TrigButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            _onOperatorClick(button.Text);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

        }
    }
}
