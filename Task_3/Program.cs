// Напишите программу, по которой пользователь вводит номер дня недели, а программа пишет его название
Console.Clear();
Console.WriteLine("Write the number from 1 to 7: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Monday");
}
else if (day == "2")
{
    Console.WriteLine("Tuesday");
}
else if (day == "3")
{
    Console.WriteLine("Wednesday");
}
else if (day == "4")
{
    Console.WriteLine("Thursday");
}
else if (day == "5")
{
    Console.WriteLine("Friday");
}
else if (day == "6")
{
    Console.WriteLine("Saturday");
}
else if (day == "7")
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("There is no day under this number, sorry :(");
}

// Если после оператора условия стоит только одно требование, то фигурные скобки можно опустить // Напишите программу, по которой пользователь вводит номер дня недели, а программа пишет его название
// Console.Clear();
// Console.WriteLine("Write the number from 1 to 7: ");
// string day = Console.ReadLine();
// if (day == "1") Console.WriteLine("Monday");
// else if (day == "2") Console.WriteLine("Tuesday");
// else if (day == "3") Console.WriteLine("Wednesday");
// else if (day == "4") Console.WriteLine("Thursday");
// else if (day == "5") Console.WriteLine("Friday");
// else if (day == "6") Console.WriteLine("Saturday");
// else if (day == "7") Console.WriteLine("Sunday");
// else Console.WriteLine("There is no day under this number, sorry :(");
