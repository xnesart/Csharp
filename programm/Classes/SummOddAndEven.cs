namespace programm;

public class SummOddAndEven
{
    public SummOddAndEven()
    {
        //  сумма чётных и нечётных чисел, из которых состоит число. Вывод наибольшей суммы.
        Console.WriteLine("Введите число");
        int userEnterValue = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        int even = 0;
        int odd = 0;

        while (userEnterValue > 0)
        {
            b = userEnterValue % 10;
            if (b % 2 == 0)
            {
                even += b;
            }
            else
            {
                odd += b;
            }
    
            // count += $"{b}";
            userEnterValue = userEnterValue / 10;
        }

        if (odd > even)
        {
            Console.WriteLine($"Сумма нечётных чисел {odd}");
        }
        else
        {
            Console.WriteLine($"Сумма чётных чисел {even}"); 
        }


        Console.ReadLine();


    }
}