// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateFillArray(int size, int min, int max) //задаем массив случайных чисел
{
    int[] ar1 = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        ar1[i] = rnd.Next(min, max);
    }
    return ar1;
}

void PrintArray(int[] ar3)
{
    Console.Write("[");
    for (int i = 0; i < ar3.Length; i++)
    {
        Console.Write($"{ar3[i]}, ");
        if (i==ar3.Length-1) Console.Write($"{ar3[i]}] -> ");
    }
}

int Search(int[] ar2)
{
    int foundNumbers = 0;
    for (int i = 0; i < ar2.Length; i++)
    {
        if (ar2[i] > 9 && ar2[i] < 100)
        {
            foundNumbers++;
        }
    }
    return foundNumbers;
}

int[] array = CreateFillArray(123, 1, 1000);
PrintArray (array);
int numfound = Search(array);
Console.Write(numfound);
Console.WriteLine();


