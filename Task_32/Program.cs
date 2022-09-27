// Задача 51: Задайте двумерный массив. Найдите суммуэлементов,
// находящихся на главной диагонали (с индексами(0,0); (1;1) и т.д.

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

int SumSameIndexes (int[,] matrix)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) summ = summ + matrix[i,j]; //summ +=matrix[i,j]
        }
    }
    return summ;
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

bool restart = true;
while(restart)
{
Console.Clear();

Random rnd = new Random(); //задаем случайное количество столбцов и строк
    int rndRows = rnd.Next(1,9);
    int rndColumns = rnd.Next(1,9);

int[,] matrix = CreateMatrixRndInt(rndRows,rndColumns,1,9);
PrintMatrix(matrix);
int result = SumSameIndexes(matrix);
Console.WriteLine($" -> {result}");

Console.WriteLine("Once again? \nPress 'Enter' if YES. Press any key if NO.");
restart = Console.ReadKey().Key==ConsoleKey.Enter;
}