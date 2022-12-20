using System;
namespace programm.Classes
{
    public class ArraySwapFirstAndSecondPart
    {
        public ArraySwapFirstAndSecondPart()
        {
            //Поменять местами первую и вторую половину массива, например,
            //для массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312.

            int[] array = new int[] { 10, 11, 5, 23, 12 };
            int[] arrayChanged = new int[array.Length];
            int[] arrayLeft = new int[array.Length];
            int[] arrayRight = new int[array.Length];

            for (int i = array.Length / 2; i < array.Length; i++)
            {
                arrayRight[i] += array[i];
                arrayChanged[i] = array[i];
                Console.WriteLine(arrayChanged[i]);

            }
            for (int i = (array.Length / 2) - 1; i >= 0; i--)
            {
                arrayLeft[i] += array[i];
                arrayChanged[i] = array[i];
                Console.WriteLine(arrayChanged[i]);

            }
            Console.ReadLine();
        }
    }
}

