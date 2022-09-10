// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Square(int a, int b)
{
    return (a * a == b || b * b == a);
}
bool result = Square(num1, num2);
if (result) Console.Write("YES");
else Console.Write("NO");