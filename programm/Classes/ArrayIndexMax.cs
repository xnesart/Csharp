using System;
namespace programm.Classes
{
    public class ArrayIndexMax
    {
        public ArrayIndexMax()
        {

            //Находим индекс у самого большого числа массива

            int[] array = new int[] { 10, 11, 5, 2, 11 };
            int max = array[0];
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(maxIndex);
            Console.ReadLine();
        }
    }
}

