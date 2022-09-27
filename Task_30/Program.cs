// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i+j;
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

int [,] matrix = CreateMatrixRndInt(4,5);
PrintMatrix(matrix);
