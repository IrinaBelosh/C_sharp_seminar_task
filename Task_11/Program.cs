// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();
Console.WriteLine("Enter coordinates: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int a, int b)
{
    if (a < 0 && b < 0) return "Third quarter";
    if (a < 0 && b > 0) return "Second quarter";
    if (a > 0 && b < 0) return "Forth quarter";
    if (a > 0 && b > 0) return "First quarter";
    return "Incorrect coordinates";
}

string result = Quarter(x, y);
Console.WriteLine(result);


