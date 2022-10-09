using Utils;
using Задание_5;

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

            int[] array1 = new int[num];
            Logic.DeleteNegative(array, array1);

            Console.WriteLine("Очищеный массив: ");
           ArrayUtils.WriteArray(array1);

        }
        else
        {
            Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
            return;
        }
    }

}