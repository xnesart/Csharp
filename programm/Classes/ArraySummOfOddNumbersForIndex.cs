using System;
namespace programm.Classes
{
    public class ArraySummOfOddNumbersForIndex
    {
        public ArraySummOfOddNumbersForIndex()
        {
            //Посчитать сумму элементов массива с нечетными индексами

            int[] array = new int[] { 10, 11, 5, 23, 11 };
            int odd = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    odd += array[i];
                }

            }
            Console.WriteLine(odd);
            Console.ReadLine();
        }
    }
}

