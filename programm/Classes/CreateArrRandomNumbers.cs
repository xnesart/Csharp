namespace programm.Classes;

public class CreateArrRandomNumbers
{
    public CreateArrRandomNumbers()
    {
        //заполняем массив случайными числами

        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * i;
            Console.Write(array[i] + " ");
        }
        Console.ReadLine();
        
        //заполняем массив случайными числами методом Random

        Random random = new Random();
        int[] array2 = new int[10];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = random.Next(-100, 100);
            Console.Write(array2[i] + " ");
        }
        Console.ReadLine();
    }
}