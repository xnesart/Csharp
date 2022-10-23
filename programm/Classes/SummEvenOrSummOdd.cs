namespace programm;

public class SummEvenOrSummOdd
{
    public SummEvenOrSummOdd()
    {
        // вывести количество чисел от 1 до N, сумма чётных которых должна быть больше суммы нечётных
        Console.WriteLine("Введите число");
        int userEnterValue = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        string count = "";
        int even = 0;
        int evenCount = 0;
        int odd = 0;
        int oddCount = 0;
        for (int i = 1; i <= userEnterValue; i++)
        {
            if (i % 2 == 0)
            {
                even += i;
                evenCount++;
            }
            else
            {
                odd += i;
                oddCount++;
            }
            count += $"{i}";
        }
        Console.WriteLine(count);

        if (odd > even)
        {
            Console.WriteLine($"Сумма нечётных чисел {odd}");
        } else
        {
            Console.WriteLine($"Сумма чётных чисел {even}"); 
        }

        Console.WriteLine($"Чётные числа {evenCount}");
        Console.WriteLine($"Нечётные числа {oddCount}");
        Console.ReadLine();
    }
}