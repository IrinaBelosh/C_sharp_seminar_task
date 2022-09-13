// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// Console.Clear();
// Console.Write("Enter a number of quarter: ");
// int a = Convert.ToInt32(Console.ReadLine());

// string Coordinates(int b)
// {
//     if (b == 1) return "x > 0 and y > 0";
//     if (b == 2) return "x < 0 and y > 0";
//     if (b == 3) return "x < 0 and y < 0";
//     if (b == 4) return "x > 0 and y < 0";
//     return "There is no such quarter";
// }

// string result = Coordinates(a);
// Console.WriteLine(result);

//Можно сделать ту же задачу короче на одну операцию
Console.Clear();
Console.Write("Enter a number of quarter: ");
string a = Console.ReadLine(); //убираем числовой формат переменной, работаем только со строкой

string Coordinates(string b)
{
    if (b == "1") return "x > 0 and y > 0";
    if (b == "2") return "x < 0 and y > 0";
    if (b == "3") return "x < 0 and y < 0";
    if (b == "4") return "x > 0 and y < 0";
    return "There is no such quarter";
}

string result = Coordinates(a);
Console.WriteLine(result);