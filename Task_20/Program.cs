// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void PrintArray1(int[] ar2)
{
    Console.Write("[");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}] -> ");
        else Console.Write($"{ar2[i]}, ");
    }
}

int[] TurnArray(int[] ar3)
{
    for (int i = 0; i < ar3.Length; i++)
    {
        if (ar3[i] != 0) ar3[i] = -ar3[i];
    }
    return new int[] {ar3.Length};
}

void PrintArray2(int[] ar2)
{
    Console.Write("[");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}

Console.Clear();
int[] array = CreateAndFillArrayRandInt(12, -99, 99);
PrintArray1(array);
Console.WriteLine();
int[] turnedArray = TurnArray(array);
PrintArray2(array);

