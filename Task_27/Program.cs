// Не используя рекурсию, выведите первые Н чисел Фибоначи
// 5 -> 0, 1, 1, 2, 3
// 3 -> 0, 1, 1,
// 7 - > 0, 1, 1, 2, 3, 5, 8

//------------с помощью массива

// void PrintArray(int[] ar2)
// {
//     Console.Write("[");
//     for (int i = 0; i < ar2.Length; i++)
//     {
//         if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
//         else Console.Write($"{ar2[i]}");
//     }
// }

// int[] Febonachi(int num)
// {
//     int[] arr = new int[num];
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i < num; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     return arr;
// }

// Console.Clear();
// Console.Write($"Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arrayFibonachi = Febonachi(number);
// Console.Write($"{number} -> ");
// PrintArray(arrayFibonachi);

//----------------без массива
Console.Clear();
Console.Write($"Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int num)
{
    int f1=0;
    int f2=1;
    int f3 = default;
    Console.Write($"{f1} {f2} ");
    for (int i = 2; i < num; i++)
    {
        f3 = f1+f2;
        Console.Write($"{f3} ");
        f1=f2;
        f2=f3;
    }
}
Console.Write($"F{number} -> ");
Fibonacci(number);
Console.WriteLine();

