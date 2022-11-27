using System;
namespace programm.Classes
{
    public class ArrayFindSummOfOdd
    {
        public ArrayFindSummOfOdd()
        {
            //Посчитать количество нечетных элементов массива

            int[] array = new int[] { 10, 11, 5, 23, 11, 13, 20, 43, 17 };
            int counter = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}

