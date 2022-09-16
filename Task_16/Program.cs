// Задача 26. напишите программу, которая принимает на вход число и выдает сколько цифр в числе
// например
// 7 -> 1
// 12345 -> 5
// 525 -> 3

// Console.Clear();
// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int DigitsNumber(int num)
// {
//     if (num != 0)
//     {
//         if (num < 0) num = -num;
//         int i = default;
//         while (num > 0)
//         {
//             num = num / 10;
//             i = i + 1;
//         }
//         return i;
//     }
//     return 1;
// }
// int digits = DigitsNumber(number);
// Console.WriteLine($"{number} -> {digits}");

//----------------------------------------------
Console.Clear();
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitsNumber(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int i;
        for (i = 0; num >0; i++)
        {
            num = num/10;
        }
        return i;
    }
    return 1;
}
int digits = DigitsNumber(number);
Console.WriteLine($"{number} -> {digits}");
