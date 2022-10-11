// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int degree = Convert.ToInt32(Console.ReadLine());
// int result = Exponention(num, degree);
// Console.WriteLine(result);

// int Exponention(int numberA, int numberB)
// {
//     if (numberB == 0) return 1;
//     return numberA *= Exponention(numberA, numberB - 1);
// }

// 2*2*2*2*2*2 - 4,8,16,32,64

//вариант из семинара (как еще можно вводить числа)
int UserNember(int number, string message) //метод выбирает числа и отбраковывает буквы
{
    Console.Write(message);
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Wrong input. Enter a number: ");
    }
    return number;
}

int Exponention(int c, int d)
{
    if (d == 0) return 1;
    if (d != 1)
    {
        c *= Exponention(c, d - 1);
    }
    return c;
}

//можно записать с помощью тернарных операторов короче
// d==0? 1: c*=Exponention(c,d-1);



bool restart = true;
while (restart)
{
    Console.Clear();
    int a = 0, b = 0;
    a = UserNember(a, "Enter a number: ");
    b = UserNember(b, "Enter an exponention: ");
    int degree = Exponention(a, b);
    Console.WriteLine(degree);

    Console.WriteLine("Once again? Press 'Enter' for YES, press any other key for NO.");
    restart = Console.ReadKey().Key == ConsoleKey.Enter;
}

