// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

//-------------------------моё решение
// void FillArray(int[] ar1)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < ar1.Length; i++)
//     {
//         ar1[i] = rnd.Next(-9, 10);
//     }
// }

// void PrintArray(int[] ar2)
// {
//     Console.Write("[");
//     for (int i = 0; i < ar2.Length; i++)
//     {
//         if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
//         else Console.Write($"{ar2[i]}, ");
//     }
// }

// int PositiveSum(int[] ar3)
// {
//     int plussum = 0;
//     for (int i = 0; i < ar3.Length; i++)
//     {
//         if (ar3[i] > 0) plussum = plussum + ar3[i];
//     }
//     return plussum;
// }

// int NegativeSum(int[] ar4)
// {
//     int minussum = 0;
//     for (int i = 0; i < ar4.Length; i++)
//     {
//         if (ar4[i] < 0) minussum = minussum + ar4[i];
//     }
//     return minussum;
// }

// Console.Clear();
// int[] randomArray = new int[12];
// FillArray(randomArray);
// PrintArray(randomArray);
// Console.WriteLine();
// int plus = PositiveSum(randomArray);
// int minus = NegativeSum(randomArray);

// Console.WriteLine($"Sum of positive numbers is {plus}");
// Console.WriteLine($"Sum of negative numbers is {minus}");

//--------------------семинарское решение, не привязанное к конкретным числам
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

int[] SumofPositiveNegativeNumbers(int[] array) //задаем метод сортирующий и суммирующий элементы
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i];
        else sumNeg += array[i];
    }
    return new int[]{sumPos, sumNeg}; //return new[]{sumPos, sumNeg}; (можно так)
}

int[] arr = CreateAndFillArrayRandInt(12, -9, 9); //создаем и заполняем массив
PrintArray(arr);//печатаем
int [] arr2 = SumofPositiveNegativeNumbers(arr);//отсортировываем и суммируем
Console.WriteLine();
Console.WriteLine($"Summ of positive numbers is {arr2[0]}");//печатаем
Console.WriteLine($"Summ of positive numbers is {arr2[1]}");
