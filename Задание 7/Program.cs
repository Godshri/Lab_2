using Utils;
using Задание_7;

class Array
{
    public static void Main()
    {
        Console.WriteLine("Введите размер массива: ");

        if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
        {
            int[] array = new int[arrayLength];

            FillingArr(array);
            Console.WriteLine("Исходный массив: ");
            ArrayUtils.WriteArray(array);

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

    static void FillingArr(int[] array)
    {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
    }

 
}