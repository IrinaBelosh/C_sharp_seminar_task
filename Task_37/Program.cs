// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
        Console.Write("[ ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == matr.GetLength(1) - 1) Console.WriteLine($"{matr[i, j],3} ]");
            else Console.Write($"{matr[i, j],3}, ");
        }
    }
}

int[] MatrixToArray(int[,] matrix1)
{
    int size = matrix1.GetLength(0) * matrix1.GetLength(1);
    int rows = matrix1.GetLength(0);
    int columns = matrix1.GetLength(1);

    int[] array = new int[size];
    int count = default;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[count] = matrix1[i,j];
        count++;
    }
}
    return array;
}

void PrintArray(int[] ar)
{
    Console.Write("[ ");
    for (int i = 0; i < ar.Length; i++)
    {
        if (i == ar.Length - 1) Console.WriteLine($"{ar[i]} ]");
        else Console.Write($"{ar[i]}, ");
    }
}

void CountElements(int[]array)
{
    int num = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]==num) count++;
        else 
        {
            Console.WriteLine($"{num} is met {count} times");
            num = array[i];
            count = 1;
        }
        if (i==array.Length-1) Console.WriteLine($"{num} is met {count} times");
    }
}

////Полный вывод всех изменений
// int[,] myMatrix = CreateMatrix(4, 3, 1, 10);
// PrintMatrix(myMatrix);
// Console.WriteLine();
// int[] myArray = MatrixToArray(myMatrix);
// PrintArray(myArray);
// Array.Sort(myArray);
// Console.WriteLine();
// PrintArray(myArray);
// CountElements(myArray);

//Краткий вывод только результата
int[,] myMatrix = CreateMatrix(2, 3, 1, 10);
PrintMatrix(myMatrix);
Console.WriteLine();
int[] myArray = MatrixToArray(myMatrix);
Array.Sort(myArray);
CountElements(myArray);
