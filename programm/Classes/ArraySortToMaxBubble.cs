using System;
namespace programm.Classes
{
    public class ArraySortToMaxBubble
    {
        public ArraySortToMaxBubble()
        {
            //Сортировка массива по возрастанию методом пузырька


            int[] array = new int[] { 10, 11, 5, 23, 12 };
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        temp = array[k];
                        array[k] = array[i];
                        array[i] = temp;

                    }

                }
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}

