using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    internal class Logic
    {
        public static void SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > k)
                {
                    array[j + 1] = array[j];
                    array[j] = k;
                    j--;
                }
            }
        }
    }
}
