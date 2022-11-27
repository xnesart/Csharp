namespace programm;

public class SummOddAndEven
{
    public SummOddAndEven()
    {
        //  сумма чётных и нечётных чисел, из которых состоит число. Вывод наибольшей суммы.
        //Console.WriteLine("Введите число");
        //int userEnterValue = Convert.ToInt32(Console.ReadLine());
        //int b = 0;
        //int even = 0;
        //int odd = 0;

        //while (userEnterValue > 0)
        //{
        //    b = userEnterValue % 10;
        //    if (b % 2 == 0)
        //    {
        //        even += b;
        //    }
        //    else
        //    {
        //        odd += b;
        //    }
        //    userEnterValue = userEnterValue / 10;
        //}
        //if (odd > even)
        //{
        //    Console.WriteLine($"Сумма нечётных чисел {odd}");
        //}
        //else
        //{
        //    Console.WriteLine($"Сумма чётных чисел {even}"); 
        //}
        //Console.ReadLine();


        Console.WriteLine("Введите число");
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int k;


        for (int i = 1; i < n; i++)
        {
            k = i;
            sum1 = 0;
            sum2 = 0;
            while (k > 0)
            {
                if (k % 2 == 0)
                {
                    sum1 += k % 10;
                    k /= 10;
                }

                else
                {
                    sum2 += k % 10;
                    k /= 10;
                }
            }
            if (sum1 > sum2)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();

    }
}