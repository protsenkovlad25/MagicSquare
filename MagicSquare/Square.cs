using System;

namespace MagicSquare
{
    class Square
    {
        private int[,] _square;

        SquareChecker squareChecker;
        SquareReader squareReader;

        public Square()
        {
            squareReader = new SquareReader();
            squareChecker = new SquareChecker();
            _square = null;
        }

        public void InitializeSquare()
        {
            _square = squareReader.Read();
            CheckSquare();
        }

        private void CheckSquare()
        {
            squareChecker.Check(_square);
        }
    }
}
