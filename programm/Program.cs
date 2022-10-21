// вывести количество чисел от 1 до N, сумма чётных которых должна быть больше суммы нечётных
Console.WriteLine("Введите число");
int userEnterValue = Convert.ToInt32(Console.ReadLine());
int b = 0;
string count = "";
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

// int final = 0;
// final = Convert.ToInt32(count);
// Console.WriteLine(final);
Console.ReadLine();
    
