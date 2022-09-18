// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Enter a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiply(int num)
{
    {
        int mult = 1;
        for (int i = 1; i <= num; i++)
        {
            mult*=i;  //mult = mult * i; 
        }
        return mult;
    }
}

if (number <= 0)
{
    Console.WriteLine("Enter a number from 0 up");
}
else
{
    int result = Multiply(number);
    Console.WriteLine($"{number} -> {result}");
}