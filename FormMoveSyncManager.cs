namespace SimpleCalculator
{
    internal static class FormMoveSyncManager
    {
        private static readonly Dictionary<Form, Point> LastPositions = new();
        private static bool _isSyncing;

        public static void Register(Form form)
        {
            if (LastPositions.ContainsKey(form))
            {
                return;
            }

            LastPositions[form] = form.Location;
            form.LocationChanged += Form_LocationChanged;
            form.FormClosed += Form_FormClosed;
        }

        private static void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is Form form)
            {
                Unregister(form);
            }
        }

        public static void Unregister(Form form)
        {
            if (!LastPositions.Remove(form))
            {
                return;
            }

            form.LocationChanged -= Form_LocationChanged;
            form.FormClosed -= Form_FormClosed;
        }

        private static void Form_LocationChanged(object? sender, EventArgs e)
        {
            if (_isSyncing || sender is not Form movedForm)
            {
                return;
            }

            if (!LastPositions.TryGetValue(movedForm, out var previous))
            {
                return;
            }

            if (!movedForm.Visible)
            {
                LastPositions[movedForm] = movedForm.Location;
                return;
            }

            var deltaX = movedForm.Left - previous.X;
            var deltaY = movedForm.Top - previous.Y;

            if (deltaX == 0 && deltaY == 0)
            {
                return;
            }

            _isSyncing = true;

            try
            {
                foreach (var form in LastPositions.Keys.ToArray())
                {
                    if (form == movedForm || form.IsDisposed)
                    {
                        continue;
                    }

                    form.Location = new Point(form.Left + deltaX, form.Top + deltaY);
                }
            }
            finally
            {
                foreach (var form in LastPositions.Keys.ToArray())
                {
                    if (!form.IsDisposed)
                    {
                        LastPositions[form] = form.Location;
                    }
                }

                _isSyncing = false;
            }
        }
    }
}
