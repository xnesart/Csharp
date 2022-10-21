using System;
namespace programm
{
    public class Evklid
    {
        public Evklid()
        {
            //Найти наибольший общий делитель 2х чисел по алгоритму Евклида
            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());



            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

