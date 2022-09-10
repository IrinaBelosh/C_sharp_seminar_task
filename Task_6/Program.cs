// Задача 6
// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа. Например: 78 ->8; 54->5

// Вариант 1 с помощью логических операторов
// Console.Clear();
// int num = new Random().Next(10, 100);
// int firstDigit = num / 10;
// int secondDigit = num % 10;

// if(firstDigit==secondDigit) Console.WriteLine("The digits are equal");
// else
// {
//     if (firstDigit > secondDigit) Console.WriteLine($"The maximum digit of the number {num} is {firstDigit}");
//     else Console.WriteLine($"The maximum digit of the number {num} is {secondDigit}");
// }

// Вариант 2 при помощи тернарных операторов
// Console.Clear();
// int num = new Random().Next(10, 100);
// int firstDigit = num / 10;
// int secondDigit = num % 10;
// if (firstDigit == secondDigit) Console.WriteLine($"{num} -> The digits are equal");
// else
// {
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;
//     Console.WriteLine($"The maximum digit of the number {num} is {max}");
// }
//Вариант 3 при помощи функции 
Console.Clear();
int num = new Random().Next(10, 100);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit == secondDigit) return 0; //Проверка на равные цифры числа
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(num);
string result = maxDigit > 0 ? maxDigit.ToString() : "The digits are equal"; //если функция возвращает 0, то ...
Console.WriteLine($"The maximum digit of the number {num} -> {result}");