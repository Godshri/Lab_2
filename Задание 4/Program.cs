
using Задание_4;

namespace Array2D
{
    class Array2D
    {
        static void Main()
        {

            Console.WriteLine("Введите размер массива: ");

            if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
            {
                int[,] array = new int[arrayLength, arrayLength];

                FillingArray(array);

                Console.WriteLine("Исходный массив: ");
                WriteArray(array);

                Console.Write("Сумма неотрицательных значений: ");
                Console.WriteLine(Logic.Summ(array));
            }
            else
            {
                Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
                return;
            }
        }
        static void FillingArray(int[,] array)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                        array[i, j] = randomGenerator.Next(0, 100);
                }
            }
        }
        static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}