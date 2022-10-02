


// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9




// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigits(int number)
// {
//     int sumInMethod = number % 10;
//     if (number != 0)
//     {
//         sumInMethod += SumDigits(number / 10);
//     }
//     return sumInMethod;
// }

// int result = SumDigits(num);
// Console.WriteLine(result);

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = Exponention(num, degree);
Console.WriteLine(result);

int Exponention(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA *= Exponention(numberA, numberB - 1);
}