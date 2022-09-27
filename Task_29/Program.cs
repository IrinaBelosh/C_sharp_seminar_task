// Задача 46: Задайте двумерный массив размером m × n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j<matrix.GetLength(1)-1) Console.Write($"{matrix[i,j], 3}, ");
            else Console.Write($"{matrix[i,j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = CreateMatrixRndInt(3,4,-9,9);
PrintMatrix(matrix);
