using System;
namespace programm.Classes
{
    public class CompareNumbers
    {
        public CompareNumbers()
        {
            // Пользователь вводит 2 числа, проверить, есть ли одинаковые числа.
            Console.WriteLine("Введите число A");
            string userEnterA = Console.ReadLine();
            Console.WriteLine("Введите число B");
            string userEnterB = Console.ReadLine();
            char c;
            char d;

            for (int i = 0; i != userEnterA.Length; i++)
            {
                c = userEnterA[i];

                for (int j = 0; j != userEnterB.Length; j++)
                {
                    d = userEnterB[j];
                    if (c == d)
                    {
                        Console.WriteLine("да");
                        return;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

