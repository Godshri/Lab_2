using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    internal class Logic
    {
        public static void DoubleNegative(int[] array, int[] array1)
        {
            int number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array1[number] = array[i];
                    array1[++number] = array[i];
                }
                else
                {
                    array1[number] = array[i];
                }
                number++;
            }

        }
    }
}
