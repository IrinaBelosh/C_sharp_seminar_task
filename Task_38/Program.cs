// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateMatrix(int rows, int columns, int min, int max)

{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == matr.GetLength(1) - 1) Console.WriteLine($"{matr[i, j],3} ]");
            else Console.Write($"{matr[i, j],3}, ");
        }
    }
}

int[] FindMinimumElement(int[,] mat)
{
    int[] ar = new int[2];
    int min = mat[0, 0];
    int a = 0;
    int b = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] < min)
            {
                min = mat[i, j];
                a = i;
                b = j;
            }
        }
    }
    Console.WriteLine($"The min element {min}. Row {a} and column {b} to cut");
    ar[0] = a;
    ar[1] = b;
    return ar;
}

int[,] CutMatrix(int rowToRemove, int columnToRemove, int[,] originalArray)
{
    int[,] result = new int[originalArray.GetLength(0) - 1, originalArray.GetLength(1) - 1];

    for (int i = 0, n = 0; i < originalArray.GetLength(0); i++)
    {
        if (i == rowToRemove)
            continue;

        for (int j = 0, u = 0; j < originalArray.GetLength(1); j++)
        {
            if (j == columnToRemove)
                continue;

            result[n, u] = originalArray[i, j];
            u++;
        }
        n++;
    }

    return result;
}

Console.Clear();
int[,] myMatrix = CreateMatrix(4, 3, 1, 100);
PrintMatrix(myMatrix);
Console.WriteLine();
int[] myArray = FindMinimumElement(myMatrix);
Console.WriteLine();
int x = myArray[0];
int y = myArray[1];
int[,] cutMatrix = CutMatrix(x, y,myMatrix);
PrintMatrix(cutMatrix);






