using Utils;
using Задание_3;

namespace SummaNeotr
{
    class SummaNeotr
    {

       public static void Main()
        {

            Console.WriteLine("Введите размер массива: ");

            if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
            {
                int[] array = ArrayUtils.GenerateArray(arrayLength);

                Console.WriteLine("Исходный массив: ");
                ArrayUtils.WriteArray(array);

                Console.WriteLine($"Сумма неотрицательных элементов: {Logic.SummNeotr(array)}");
                

            }
            else
            {
                Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
                return;
            }
        }

   
    }
}