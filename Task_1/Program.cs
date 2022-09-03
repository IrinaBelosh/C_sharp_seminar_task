// Задача 1. Напишите программу, которая на входе принимает число и на выходе выводит его квадрат
Console.Clear();
Console.Write("Enter an integer: ");
int num = Convert.ToInt32(Console.ReadLine()); // int num = int.Parse(Console.ReadLine()) - та же команда, но не учитывает нулевое значение
int square = num * num;
Console.WriteLine($"Square number of {num} is {square}"); // возможно Console.WriteLine("Square number of" + num + "is" + square")

