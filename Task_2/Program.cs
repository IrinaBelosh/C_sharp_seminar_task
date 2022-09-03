// Напишите программу, которая на входе принимает два числа и определяет является ли первое квадратом другого.
Console.Clear();
Console.Write("Enter the first digit: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second digit: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (square == num1)
{
    Console.WriteLine($"Digit {num1} is the square to {num2}");
}
else
{
    Console.WriteLine($"Digit {num1} is not the square to {num2}");
}