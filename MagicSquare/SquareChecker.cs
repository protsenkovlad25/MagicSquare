using System;

namespace MagicSquare
{
    class SquareChecker
    {
        private int[,] _square;
        private int _size, _magicConstant, _sumRows, _sumColums, _sumMainDiagonal, _sumSideDiagonal;
        private bool _result;

        SquareWriter squareWriter;

        public SquareChecker()
        {
            _magicConstant = 0;
            _sumRows = 0;
            _sumColums = 0;
            _sumMainDiagonal = 0;
            _sumSideDiagonal = 0;
            squareWriter = new SquareWriter();
        }

        public void Check(int[,] square)
        {
            _square = square;
            _size = square.GetUpperBound(0) + 1;
            _magicConstant = (int)(_size * (Math.Pow(_size, 2) + 1)) / 2;

            _result = CheckRows() && CheckColums() && CheckDiagonals();

            squareWriter.Write(_result, _square);
        }

        private bool CheckRows()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                    _sumRows += _square[i, j];

                if (_sumRows != _magicConstant)
                    return false;

                _sumRows = 0;
            }
            return true;
        }

        private bool CheckColums()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                    _sumColums += _square[j, i];

                if (_sumColums != _magicConstant)
                    return false;

                _sumColums = 0;
            }
            return true;
        }

        private bool CheckDiagonals()
        {
            for (int i = 0; i < _size; i++)
            {
                _sumMainDiagonal += _square[i, i];
                _sumSideDiagonal += _square[i, _size - 1 - i];
            }
            if (_sumMainDiagonal != _magicConstant || _sumSideDiagonal != _magicConstant)
                return false;

            return true;
        }
    }
}
