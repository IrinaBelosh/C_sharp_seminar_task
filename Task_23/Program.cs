// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillRandomArray(int size1, int min, int max)
{
    int[] array = new int[size1];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] ar1)
{
    Console.Write("[");
    for (int i = 0; i < ar1.Length; i++)
    {
        if (i == ar1.Length - 1) Console.WriteLine($"{ar1[i]}]");
        else Console.Write($"{ar1[i]}, ");
        
    }
}

int[] PairMultiply(int[] ar2)
{
    int size = ar2.Length/2;
    if (ar2.Length%2==1) size+=1;
    int[] ar3 = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i==ar2.Length-1-i) ar3[i]=i;
        else ar3[i]=ar2[i]*ar2[ar2.Length-1-i];
    }
    return ar3;
}

int[]array = FillRandomArray(6,1,11);
PrintArray(array);
int[] array2 = PairMultiply(array);
PrintArray(array2);