// // 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Enter a three-difit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1000 && num > 99)
{
    num = num % 10;
    Console.WriteLine($"{num}");
}
else
{
    Console.WriteLine("The number you entered is not three-digit. Enter a three-digit number.");
}