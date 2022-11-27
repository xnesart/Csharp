namespace programm.Classes;

public class FindMaxDivOfValue
{
    public FindMaxDivOfValue()
    {
        //Находим максимальный делитель числа
        Console.WriteLine("Введите число А");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = a - 1;

        for (int i = b; i > 0; i--)
        {
            if (a % i == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
        Console.ReadLine();
    }
}