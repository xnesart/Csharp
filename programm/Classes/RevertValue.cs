namespace programm;

public class RevertValue
{
    public RevertValue()
    {
        // Перевернуть число задом наперед
        Console.WriteLine("Введите число");
        int userEnterValue = Convert.ToInt32(Console.ReadLine());
        int b = 0;
        string count = "";

        while (userEnterValue > 0)
        {
            b = userEnterValue % 10;
            count += $"{b}";
            userEnterValue = userEnterValue / 10;
        }
        int final = 0;
        final = Convert.ToInt32(count);
        Console.WriteLine(final);
        Console.ReadLine();
    }
}