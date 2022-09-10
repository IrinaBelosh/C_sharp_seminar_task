// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

//Вариант первый с методом
// Console.Clear();
// Console.Write("Enter the first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int RemDiv(int divisible, int div)
// {
//     int remdiv = divisible % div;
//     return remdiv;
// }

// if (num1 > num2)
// {
//     if (num1 % num2 == 0)
//     {
//         Console.Write($"Number {num1} is multiple of {num2}.");
//     }
//     else
//     {
//         int rd = RemDiv(num1, num2);
//         Console.Write($"Number {num1} is not multiple of {num2}, the remainder is ");
//         Console.WriteLine(rd);
//     }
// }
// else
// {
//     Console.WriteLine($"{num1} is not divisible of {num2}. No remainder.");
// }


//Вариант второй с bool методом
Console.Clear();
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Multip(int a, int b)
{
    return a % b == 0;
}

bool result = Multip(num1, num2);
if (num1>num2)
{
if (result) Console.WriteLine($"{num1} is multiple of {num2}");
else Console.WriteLine($"{num1} is not multiple of {num2}, remainder = {num1 % num2}");
}
else
{
    Console.WriteLine($"{num1} is not multiple of {num2}. No remainder.");
}

//Вариант третий без метода
// Console.Clear();
// Console.Write("Enter the first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int div = num1 % num2;
// if (num1 > num2)
// {
//     if (div == 0)
//     {
//         Console.WriteLine($"{num1} is multiple of {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"{num1} is not multiple of {num2}, the remainder = {div}");
//     }
// }
// else
// {
//     Console.WriteLine($"{num1} is not multiple of {num2}, no remainder.");
// }
