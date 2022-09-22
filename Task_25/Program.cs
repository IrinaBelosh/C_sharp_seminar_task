// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет может ли существовать треугольник с такими сторонами.
// (Теорема треугольника: каждая сторона треугольника меньше суммы двух других его сторон).

Console.Clear();
Console.Write($"Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b) Console.WriteLine($"{a} {b} {c} -> The triangle is possible");
else Console.WriteLine($"{a} {b} {c} -> The triangle is NOT possible");
