using System.Linq;
using Utils;
using Задание_6;

class Array
{
    public static void Main()
    {
        Console.WriteLine("Введите размер массива: ");

        if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
        {
            int num;
            int[] array = ArrayUtils.GenerateArray(arrayLength);

            Console.WriteLine("Исходный массив: ");
            ArrayUtils.WriteArray(array);

            num = ArrayUtils.CountPositiveElem(array);

            int[] array1 = new int[array.Length + (array.Length - num)];
            Logic.DoubleNegative(array, array1);

            Console.WriteLine("Измененный массив: ");
            ArrayUtils.WriteArray(array1);

        }
        else
        {
            Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
            return;
        }
    }

}