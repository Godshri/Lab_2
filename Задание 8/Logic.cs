using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    internal class Logic
    {
        public static int[] GenerateArray(int arrayLength)
        {
            int[] array = new int[arrayLength];

            Random randomGenerator = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = randomGenerator.Next(0, 10);
            }
            return array;
        }
        public static void Desired(int[] array, ref int isk)
        {
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == isk)
                {
                    n = i + 1;
                    Console.WriteLine($"Индекс: {n}");
                }
            }
        }
    }
}
