using System;

namespace MagicSquare
{
    class SquareReader
    {
        private int[,] _square;
        private int _size;

        public int[,] Read()
        {
            ReadSize();
            ReadSquare();

            return _square;
        }
        
        private void ReadSize()
        {
            Console.Write("Размер магического квадрата: ");
            _size = int.Parse(Console.ReadLine());
            _square = new int[_size, _size];
        }

        private void ReadSquare()
        {
            Console.WriteLine("\nВведите попорядку все значения квадрата\n" +
                "(Значения будут располагаться слева на право)");
            for (int i = 0; i < _size; i++)
                for (int j = 0; j < _size; j++)
                {
                    _square[i, j] = int.Parse(Console.ReadLine());
                    while (_square[i, j] > Math.Pow(_size, 2))
                    {
                        Console.WriteLine($"Число превышает значение {_size}*{_size} = {Math.Pow(_size, 2)}. Введите число меньше");
                        _square[i, j] = int.Parse(Console.ReadLine());
                    }
                }
        }
    }
}
