namespace programm.Classes;

public class ArrayIndexMinMax
{
    public ArrayIndexMinMax()
    {
        //Находим индекс минимального элемента в массиве

        int[] array = new int[] {10,6, 8, 1 , 5 ,2, 11};
        int min = array[0];
        int count = 0;
        int minIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            count++;
            if (min > array[i])
            {
                min = array[i];
                minIndex = count - 1;
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(minIndex);
        Console.ReadLine();
    }
}