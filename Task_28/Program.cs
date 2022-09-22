// Напишите программу, которая копирует массив с помощью поэлементного копирования


int[] CreateAndFillArrayRandInt(int size, int min, int max)//задаем метод, который создает и заполняет массив используя на вводе размер массива и его диапазон
{

    int[] array = new int[size]; //задаем новый массив и его размер
    Random rnd = new Random(); //вводим случайную переменную отдельно
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1); //задаем диапазон
    }
    return array;
}

void PrintArray(int[] ar2)
{
    Console.Write("[");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}

int[] CopyArray(int[]ar1)
{
    int size = ar1.Length;
    int[] ar2 = new int[size];
    for (int i = 0; i < size; i++)
    {
        ar2[i]=ar1[i];
    }
    return ar2;
}

Console.Clear();
int[] array = CreateAndFillArrayRandInt(12,1,99);
PrintArray(array);
Console.WriteLine();
CopyArray(array);
PrintArray(array);


