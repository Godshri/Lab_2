using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    internal class Logic
    {
        public static bool IsSames(int[] array, int[] array1, bool equality)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array1[i])
                {
                    count++;
                }
            }

            if (count == array.Length)
            {
                equality = true;
            }

            else
            {
                equality = false;
            }
            return equality;
        }
        public static void Sort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int k = mass[i];
                int j = i - 1;

                while (j >= 0 && mass[j] > k)
                {
                    mass[j + 1] = mass[j];
                    mass[j] = k;
                    j--;
                }
            }
        }
    }
}
