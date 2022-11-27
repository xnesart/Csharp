using System;
namespace programm.Classes
{
    public class halfDivision
    {
        public halfDivision()
        {
            //Пользователь вводит целое положитиельное число, которое является кубом целого числа N, найти N методом половинного деления

            Console.WriteLine("введите число A");
            int a = int.Parse(Console.ReadLine());
            int n = a * a * a;
            int leftBorder = 0;
            int rightBorder = 300000;
            int middle = 0;
            int c = 0;

            while (c != n && c >= 0)
            {
                middle = (rightBorder + leftBorder) / 2;
                c = middle;

                if (middle > n)
                {
                    rightBorder = middle;
                }
                else
                {
                    leftBorder = middle;
                }
            }
            Console.WriteLine(c);


            Console.ReadLine();
        }
    }
}

