namespace programm;

public class FindOddValuesOfNumber
{
    public FindOddValuesOfNumber()
    {
        Console.WriteLine("Введите число");
        int userEnterValue = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        int count = 0;

            while (userEnterValue > 0)
        {
            b = userEnterValue % 10;
            if (b % 2 == 0)
            {
                userEnterValue = userEnterValue / 10;
            }
            else
            {
                userEnterValue = userEnterValue / 10;
                count++;
            }
            Console.WriteLine(count);
        }
        Console.ReadLine();
    }
}