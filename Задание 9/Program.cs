using System;
using Задание_9;

class Array
{
    private static bool equality;

    public static void Main()
    {
        Console.WriteLine("Введите размер массива: ");

        if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
        {
            int[] array = new int[arrayLength];
            int[] array1 = new int[arrayLength];
            Console.WriteLine("Введите первый массив: ");
            FillingArr(array);

            Console.WriteLine("Введите второй массив: ");
            FillingArr(array1);

            Logic.Sort(array);
            Logic.Sort(array1); 

            Logic.IsSames(array, array1, equality);
            if(equality = true)
            {
                Console.WriteLine("Массивы одинаковые");
            }
            else
            {
                Console.WriteLine("Массивы не одинаковые");
            }


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