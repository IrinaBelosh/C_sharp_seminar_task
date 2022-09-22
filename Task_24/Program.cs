// Задача 39: Напишите программу, которая перевернет одномерный массив.
// Последний элемент будет на первом месте, второй на предпоследнем и тп
// [1, 5, 9, 6] -> [6, 9, 5, 1]
// [1, 8, 5] -> [5, 8, 1]

int[] CreateAndFillArrayRandInt(int size, int min, int max)//задаем метод, который создает и заполняет массив используя на вводе размер массива и его диапазон
{

    int[] ar1 = new int[size]; //задаем новый массив и его размер
    Random rnd = new Random(); //вводим случайную переменную отдельно
    for (int i = 0; i < size; i++)
    {
        ar1[i] = rnd.Next(min, max + 1); //задаем диапазон
    }
    return ar1;
}

void PrintArray(int[] ar2)//метод печатающий массив
{
    Console.Write("[");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}

// Array.Reverse();//есть уже встроенный метод. Выглядит так.

void ReverseArray(int[] ar3)
{
    int size = ar3.Length;
    int temp = 0;
    for (int i = 0; i < size / 2; i++)
    {
        temp = ar3[i];
        ar3[i] = ar3[size-1-i];
        ar3[size-1-i]= temp;
    }
}

Console.Clear();
int[] array = CreateAndFillArrayRandInt(10,1,99);
PrintArray(array);
Console.Write(" -> ");
ReverseArray(array);
PrintArray(array);
Console.WriteLine();