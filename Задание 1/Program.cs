
using Utils;
using Задание_1;

class Array
{
   public static void Main()
    {

        Console.WriteLine("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(),out int arrayLength) && arrayLength > 0)
        {
            int[] array = ArrayUtils.GenerateArray(arrayLength);

            Console.WriteLine("Исходный массив: ");
            ArrayUtils.WriteArray(array);

            Console.WriteLine($"Минимальный элемент: {Logic.FindMin(array)}");

            Console.WriteLine($"Максимальный элемент: {Logic.FindMax(array)}");
            

            Console.WriteLine("Отсортированный массив: ");
            Logic.SortArray(array);

            ArrayUtils.WriteArray(array);
        }
        else
        {
            Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
            return;
        }

    }


}