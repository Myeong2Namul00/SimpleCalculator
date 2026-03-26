namespace SimpleCalculator
{
    public class Form2 : Form
    {
        private readonly List<string> _calculationHistory;
        private readonly Action<string> _loadHistoryAction;

        private readonly ListBox lstHistory;
        private readonly Button btnDeleteSelected;
        private readonly Button btnClearAll;
        private readonly Button btnLoadToCalculator;

        public Form2(List<string> calculationHistory, Action<string> loadHistoryAction)
        {
            _calculationHistory = calculationHistory;
            _loadHistoryAction = loadHistoryAction;

            Text = "History";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(330, 809);

            lstHistory = new ListBox
            {
                Name = "lstHistory",
                Font = new Font("한컴 고딕", 22F, FontStyle.Bold, GraphicsUnit.Point),
                HorizontalScrollbar = true,
                IntegralHeight = false,
                Location = new Point(12, 12),
                Size = new Size(306, 670)
            };

            btnDeleteSelected = new Button
            {
                Name = "btnDeleteSelected",
                Text = "선택 삭제",
                FlatStyle = FlatStyle.Flat,
                Location = new Point(12, 700),
                Size = new Size(95, 36)
            };

            btnClearAll = new Button
            {
                Name = "btnClearAll",
                Text = "전체 삭제",
                FlatStyle = FlatStyle.Flat,
                Location = new Point(117, 700),
                Size = new Size(95, 36)
            };

            btnLoadToCalculator = new Button
            {
                Name = "btnLoadToCalculator",
                Text = "불러오기",
                FlatStyle = FlatStyle.Flat,
                Location = new Point(223, 700),
                Size = new Size(95, 36)
            };

            btnDeleteSelected.Click += BtnDeleteSelected_Click;
            btnClearAll.Click += BtnClearAll_Click;
            btnLoadToCalculator.Click += BtnLoadToCalculator_Click;

            Controls.Add(lstHistory);
            Controls.Add(btnDeleteSelected);
            Controls.Add(btnClearAll);
            Controls.Add(btnLoadToCalculator);

            RefreshHistory();
        }

        public void RefreshHistory()
        {
            lstHistory.BeginUpdate();
            lstHistory.Items.Clear();

            foreach (var item in _calculationHistory)
            {
                lstHistory.Items.Add(item);
            }

            lstHistory.EndUpdate();
        }

        private void BtnDeleteSelected_Click(object? sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex < 0)
            {
                return;
            }

            _calculationHistory.RemoveAt(lstHistory.SelectedIndex);
            RefreshHistory();
        }

        private void BtnClearAll_Click(object? sender, EventArgs e)
        {
            _calculationHistory.Clear();
            RefreshHistory();
        }

        private void BtnLoadToCalculator_Click(object? sender, EventArgs e)
        {
            if (lstHistory.SelectedItem is not string selectedExpression)
            {
                return;
            }

            _loadHistoryAction(selectedExpression);
        }
    }
}
