using System.Drawing;

namespace Tetris
{
    class Shape
    {
        public int Width;
        public int Height;
        public int[,] Position;
        public Brush Color;

        private int[,] LastPosition;
        public void turn()
        {
            LastPosition = Position;

            Position = new int[Width, Height];

            for (int i = 0; i < Width; i++){
                for (int j = 0; j < Height; j++){
                    Position[i, j] = LastPosition[Height - 1 - j, i];
                }
            }

            var temp = Width;
            Width = Height;
            Height = temp;
        }

        // quand la forme ne peut pas tourner
        public void rollback()
        {
            Position = LastPosition;

            var temp = Width;
            Width = Height;
            Height = temp;
        }
    }
}
