// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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

bool FindNumber(int[] ar1, int num)
{
    bool yes = false;
    for (int i = 0; i < ar1.Length; i++)
    {
        if (ar1[i]==num)
        {
            yes = true;
            break;
        }
    }
    return yes;
}


Console.Clear();
int[] array = CreateAndFillArrayRandInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Enter a desired number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool res = FindNumber(array, number);
if (res) Console.WriteLine("YES");
else Console.WriteLine("NO");
