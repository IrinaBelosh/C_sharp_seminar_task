// Напишите программу, которая на вход принимает число (А),
// а на выходе выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sumnumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum = sum+=i (можно записать так)
    }
    return sum;
}
int sum = Sumnumbers(number);
Console.WriteLine($"The sum of numbers from 1 to {number} is {sum}");


