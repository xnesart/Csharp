using System;
namespace programm
{
    public class Нахождение_Nго_числа_ряда_фибоначи
    {
        public Нахождение_Nго_числа_ряда_фибоначи()
        {
            Console.WriteLine("Введите число N");
            int n = int.Parse(Console.ReadLine());
            int fb1 = 1;
            int fb2 = 1;
            int sum = 0;



            for (int i = 1; i <= n; i++)
            {
                fb1 = fb2;
                fb2 = sum;
                sum = fb1 + fb2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}

