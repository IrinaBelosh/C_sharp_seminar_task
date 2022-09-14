// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// while (count <= n)
// {
//     int a = count * count;
//     Console.WriteLine($"{count}  {a}");
//     count++;
// }


// for(int count = 1; count <= n; count++) //Через цикл for все в столбик
// {
//     int a = count * count;
//     Console.WriteLine($"{count}  {a}");
// }

for(int count = 1; count <= n; count++) //то же, но покороче, без промежуточной переменной
{
        Console.WriteLine($"{count}  {count*count,3}"); //Число 3 после запятой, проставит пробелы как на трехзначное число
}

// Console.Write($"{n}  ->  "); // число и квадраты в линеечку
// for(int count = 1; count <= n; count++)
// {
//     int a = count * count;
//     Console.Write($"{a}, ");
// }
// Console.WriteLine();

// Console.Write($"{n}  ->  "); // то же, но покороче
// for(int count = 1; count <= n; count++)
// {
//         Console.Write($"{count*count}, ");
// }
// Console.WriteLine();


