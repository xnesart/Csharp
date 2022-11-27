namespace programm.Classes;

public class HalfDivFunction
{
    public HalfDivFunction()
    {
        // y = 5*x+6; найти х
        Console.WriteLine("введите число Y");
        double y = Convert.ToDouble(Console.ReadLine());
        double left = 0;
        double right = y;
        double x = (y - 6) / 5;
        double middle = 0;

        while (!(x == (y-6)/5))
        {
            middle = (left + right) / 2;

            if (middle > x)
            {
                right = middle;
            }
            else
            {
                left = middle;
            }
        }
        Console.WriteLine(x);
        Console.ReadLine();
    }
}