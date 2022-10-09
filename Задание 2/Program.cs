using Задание_2;

class Array3D
{
    static void Main()
    {
      
        Console.WriteLine("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(), out int arrayLength) && arrayLength > 0)
        {
            int[,,] array = new int[arrayLength, arrayLength, arrayLength];

            FillingArray(array);

            Console.WriteLine("Исходный массив: ");
            WriteArray(array);

            Logic.SwitchPositiveByZero(array);

            Console.WriteLine("Измененный массив: ");

            WriteArray(array);
        }
        else
        {
            Console.WriteLine("Ошибка. Введите положительное целочисленное значение");
            return;
        }
    }

    static void FillingArray(int[,,] array)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = randomGenerator.Next(-50, 50);
                }
            }
        }
    }
    static void WriteArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"Массив #{i + 1}:\n");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write(array[i, j, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    

}