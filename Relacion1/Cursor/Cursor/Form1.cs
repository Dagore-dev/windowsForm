namespace Cursor
{
    public partial class Cursor : Form
    {
        public Cursor()
        {
            InitializeComponent();
        }

        private void MoveCursor(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            Point origin = new Point(240, 180);

            switch (btn.Text)
            {
                case "✜":
                    labelCursor.Location = origin;
                    break;
                case "⇖":
                    labelCursor.Left -= 5;
                    labelCursor.Top -= 5;
                    break;
                case "⇑":
                    labelCursor.Top -= 5;
                    break;
                case "⇗":
                    labelCursor.Left += 5;
                    labelCursor.Top -= 5;
                    break;
                case "⇐":
                    labelCursor.Left -= 5;
                    break;
                case "⇒":
                    labelCursor.Left += 5;
                    break;
                case "⇙":
                    labelCursor.Left -= 5;
                    labelCursor.Top += 5;
                    break;
                case "⇓":
                    labelCursor.Top += 5;
                    break;
                case "⇘":
                    labelCursor.Left += 5;
                    labelCursor.Top += 5;
                    break;
                default:
                    labelCursor.Location = origin;
                    break;
            }
        }
    }
}