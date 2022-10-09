namespace Utils
{
    public static class ArrayUtils
    {
        public static int[] GenerateArray(int arrayLength)
        { 
            int[] array = new int[arrayLength];

            Random randomGenerator = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = randomGenerator.Next(-20, 50);
            }
            return array;
        }

      public static int[] WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            return array;
        }

        public static int CountPositiveElem(int[] mass)
        {
            int num = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                { num++; }
            }
            return num;
        }
    }
}