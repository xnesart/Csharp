using System;
namespace programm.Classes
{
    public class ArrayMinIndex
    {
        public ArrayMinIndex()
        {

            int[] array = new int[] { 10, 11, 5, 2, 11 };
            int min = array[0];
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(minIndex);
            Console.ReadLine();
        }
    }
}

