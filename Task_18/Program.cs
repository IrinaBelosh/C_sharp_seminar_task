// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//------------------------------
// массив просто выводится на экран без скобок и запятых

// Console.Clear();
// int[] array = new int[8];//задаем массив

// void FillArray (int[] ar1)
// {
//     for (int i = 0; i < ar1.Length; i++)
//     {
//         ar1[i] = new Random().Next(0,2);
//     }
// }

// void PrintArray(int[] ar2)
// {
//     Console.Write("[");
//     for (int i = 0; i < ar2.Length; i++)
//     {
//         Console.Write(ar2[i]);
//     }
//     Console.Write("]");
// }

// PrintArray(array);
// Console.WriteLine();
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();


//-------------------------------------
// то же самое, но с запятыми
Console.Clear();
int[] array = new int[8];//задаем массив

void FillArray (int[] ar1)
{
    Random rnd = new Random(); //лучше создавать отдельную переменную для рандомных чисел вне цикла иначе при большой скорости обработки на выходе все числа будут одинаковыми
    for (int i = 0; i < ar1.Length; i++)
    {
        ar1[i] = rnd.Next(0,2);
    }
}

void PrintArray(int[] ar2)
{
    for (int i = 0; i < ar2.Length; i++)
    {
        if(i==0) Console.Write("[");
        if (i==ar2.Length-1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}

PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();