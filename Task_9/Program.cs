// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//Вариант 1 с методами
Console.Clear();
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool Seven(int a)
{
    return a % 7==0;
}

bool TwentyT(int b)
{
    return b % 23 ==0;
}

if (num % 7 ==0 && num % 23 == 0)
{
    Console.WriteLine($"{num} is multiple of both");
}
else
{
    bool res1 = Seven(num);
    if (res1) Console.WriteLine($"{num} is multiple only of 7");
    else Console.WriteLine($"{num} is not multiple of 7");
    bool res2 = TwentyT(num);
    if (res2) Console.WriteLine($"{num} is multiple only of 23");
    else Console.WriteLine($"{num} is not multiple  of 23");
}


