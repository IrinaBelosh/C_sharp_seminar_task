// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1) Console.WriteLine($"{array[i, j],3} ]");
            else Console.Write($"{array[i, j],3},");
        }
    }
}

// void ChangeRowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("The procedure is impossible");
//     else
//     {
//         int temp = default;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//                 if (i != j)
//                 {
//                     temp = array[i, j];
//                     array[i, j] = array[j, i];
//                     array[j, i] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] myArray = CreateArray(3, 3, 1, 100);
// PrintArray(myArray);
// Console.WriteLine();
// ChangeRowsToColumns(myArray);
// PrintArray(myArray);

// 6  33 44 25                     i;j     i;j+1      i;j+2       i;j+3

// 9  78  7 80                     i+1;j   i+1;j+1    i+1;j+2     i+1;j+3

// 82 41 98 78  i==j диагональ     i+2;j   i+2;j+1     i+2;j+2    i+2;j+3

// 4  4  43 82                     i+3;j   i+3;j+1     i+3;j+2    i+3;j+3

//Решение из семинара с промежуточным массивом и проверкой bool
int[,] ChangePlace(int[,] arr)
{
    int[,] arrResult = new int[arr.GetLength(0), arr.GetLength(1)]; //промеж массив
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrResult[i, j] = arr[j, i]; //в него сразу записываем значения
        }
    }
    return arrResult;
}

bool CheckSq(int[,]array) //проверка на квадратность
{
    return array.GetLength(0)==array.GetLength(1); //это условие при котором проверка пройдена
}

int[,] myArray = CreateArray(3, 3, 1, 100);
PrintArray(myArray);
Console.WriteLine();

if (CheckSq(myArray)) //проверка на квадратность
{
    int[,] ar = ChangePlace(myArray);
    PrintArray(ar);
}