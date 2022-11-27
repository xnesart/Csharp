using System;
namespace programm.Classes
{
    public class ArrayMin
    {
        public ArrayMin()
        {
            int[] array = new int[] { 10, 1, 5, 2, 11 };
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}

