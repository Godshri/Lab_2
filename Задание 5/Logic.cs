using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Logic
    {
        public static void DeleteNegative(int[] array, int[] array1)
        {
            int Long = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array1[Long++] = array[i];
                }
            }
        }
    }
}
