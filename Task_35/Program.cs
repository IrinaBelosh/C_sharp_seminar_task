// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (j == ar.GetLength(1) - 1) Console.WriteLine($"{ar[i, j],3} ]");
            else Console.Write($"{ar[i, j],3}, ");
        }
    }
}

// void ChangeFirstAndLastRows(int[,] ar1)
// {
//     int k = ar1.GetLength(0) - 1;
//     int temp = default;
//     for (int i = 0; i < ar1.GetLength(0); i++)
//     {
//         for (int j = 0; j < ar1.GetLength(1); j++)
//         {
//             if (i == 0)
//             {
//                 temp = ar1[i, j];
//                 ar1[i, j] = ar1[k, j];
//                 ar1[k, j] = temp;
//             }
//         }
//     }
// }

//Решение попроще из семинара
void ChangeFirstAndLastRows(int[,] ar1)
{
    int k = ar1.GetLength(0) - 1;
    int temp = default;
    for (int j = 0; j < ar1.GetLength(1); j++)
    {
        temp = ar1[0, j];
        ar1[0, j] = ar1[k, j];
        ar1[k, j] = temp;
    }
}

int[,] myArray = CreateArray(5, 4, 1, 100);
PrintArray(myArray);
Console.WriteLine();
ChangeFirstAndLastRows(myArray);
PrintArray(myArray);

