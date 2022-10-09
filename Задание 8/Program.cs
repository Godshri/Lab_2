using Utils;
using Задание_8;

class Array
{
    public static void Main()
    {

        Console.WriteLine("Введите искомое значение: ");
        if (int.TryParse(Console.ReadLine(), out int desired) && desired >= 0 && desired <= 10)
        {
            Console.WriteLine("Введите размер массива: ");

            if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
            {
                int[] array = Logic.GenerateArray(arrayLength);
                Console.WriteLine("Исходный массив: ");

               ArrayUtils.WriteArray(array);
               Logic.Desired(array, ref desired);
        
            }
            else
            {
                Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
                return;
            }

        }
        else
        {
            Console.WriteLine("Ошибка. Введите число от 1 до 10");
            return;
        }
    }

}