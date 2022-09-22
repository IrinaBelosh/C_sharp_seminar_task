// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 01

//------------------моё решение
// int Size(int num)
// {
//     int size = 1;
//     while (num / 2 > 0)
//     {
//         num = num / 2; //22,11,5,2,1,0
//         size = size + 1;//1,2,3,4,5,6

//     }
//     return size;
// }

// int[] DecToBin(int num1)
// {
//     int size = Size(num1);
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[size-1-i] = num1 % 2;
//         num1 = num1 / 2;
//     }
//     return arr;
// }

// void PrintArray(int[] ar2)
// {
//     Console.Write("[");
//     for (int i = 0; i < ar2.Length; i++)
//     {
//         if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
//         else Console.Write($"{ar2[i]}");
//     }
// }

// Console.Clear(); 
// Console.Write($"Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] BinArray = DecToBin(num);
// PrintArray(BinArray);

//----------вариант с семинара не с массивом, а с числом


int ConvertNumber(int num)
{
    int result = 0;
    int rasryadDecimal = 1;
    while (num > 0)
    {
        result = (num%2)*rasryadDecimal + result; // можно result+= (num%2)*rasryadDecimal//получаем ноль или один и умножаем на десятичный разряд, какое место надо, якобы это десятичное число
        num = num/2;
        rasryadDecimal*=10;//увеличиваем разряд, чтобы число вышло первым, ане последним
    }
    return result; //возвращаем десятичное число
}

Console.Clear(); 
int num = default;
Console.Write($"Enter a number: ");
while (!int.TryParse(Console.ReadLine(), out num))//эта команда преобразует тип string в int и кладет его в переменную num. если число будет не целое или отрицательное, то выдаст ошибку
{
    Console.WriteLine("Incorrect number. \nEnter a round number."); //и команда не будет прерываться, пока не введем правильное число (\n перевод на новую строку)
}
int result = ConvertNumber(num);
Console.WriteLine($"{result}");