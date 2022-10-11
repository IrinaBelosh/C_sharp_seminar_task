// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
//
// Console.Write("Введите число M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int tempBig = default;
// int tempSmall = default;
// if (numM > numN)
// {
//     tempBig=numM;
//     tempSmall = numN;
// }
// else 
// {
//     tempBig=numN;
//     tempSmall=numM;
// }

// Console.Write($"M = {tempSmall}; N = {tempBig} -> ");
// NaturalNumbers(tempSmall, tempBig);
// Console.WriteLine();
// Console.ResetColor();


// void NaturalNumbers(int numberM, int numberN)
// {
//     if (numberN < numberM) return;
//     NaturalNumbers(numberM, numberN - 1);    
//     Console.Write($"{numberN} ");
// }

//Моё решение
// bool restart = true;
// while (restart)
// {
//     Console.WriteLine("Enter two numbers (M N) : ");
//     string[] array = Console.ReadLine().Split();
//     int m = int.Parse(array[0]);
//     int n = int.Parse(array[1]);
//     if (m == n) Console.WriteLine("Digits must not be equal.");
//     if (m < n)
//     {
//         PrintDigits(m, n);
//         Console.WriteLine();
//     }
//     if (m > n)
//     {
//         PrintDigits2(n, m);
//         Console.WriteLine();
//     }

//     Console.WriteLine("To start again pres 'Enter', to quit press any key.");
//     restart = Console.ReadKey().Key == ConsoleKey.Enter;
// }

// void PrintDigits(int min, int max)
// {
//     if (max < min) return;
//     PrintDigits(min, max - 1);
//     Console.Write($"{max} ");
// }

// void PrintDigits2(int min, int max)
// {
//     if (max < min) return;
//     Console.Write($"{max} ");
//     PrintDigits2(min, max - 1);
// }

//Второй вариант из семинара
Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(numM, numN);

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2) Console.WriteLine(num2);
    if (num1 > num2) 
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1-1, num2);
    }
    if (num1<num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1+1, num2);
    }
}