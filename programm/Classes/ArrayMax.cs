namespace programm.Classes;

public class ArrayMax
{
    public ArrayMax()
    {
        //Находим наибольшее число в массиве

        int[] array = new int[] {10, 1 , 5 ,2, 11};
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        Console.WriteLine(max);
        Console.ReadLine(); 
    }
}