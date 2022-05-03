namespace Notepad
{
    internal class CursorPosition
    {
        private int column;
        private int row;

        public CursorPosition(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public int Column { get => column; }
        public int Row { get => row; }
    }
}