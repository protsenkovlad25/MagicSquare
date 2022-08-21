using System;

namespace MagicSquare
{
    class SquareWriter
    {
        private int[,] _square;
        private int _size;

        public void Write(bool result, int[,] square)
        {
            _square = square;
            _size = square.GetUpperBound(0) + 1;

            WriteSquare();

            if (result)
            {
                Console.WriteLine("Это нормальный магический квадрат");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Это НЕ нормальный магический квадрат");
                Console.ReadKey();
            }
        }

        private void WriteSquare()
        {
            Console.WriteLine();
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                    Console.Write(_square[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
