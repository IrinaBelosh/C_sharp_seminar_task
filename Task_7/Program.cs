// Напишите программу, которая выдает случайное трехзначное число и 
// удаляет вторую цифру этого числа. 
// Например: 751 ->71, 483->43

int number = new Random().Next(100, 1000); //Определяем случайное число

int secondOut(int num) // Задаём метод
{
    int fristDigit = num / 100 * 10;
    int secondDigit = num % 10;
    return fristDigit + secondDigit;
}
int neededNum = secondOut(number); //Помещаем результат метода в переменную neededNum
Console.WriteLine($"{number} -> {neededNum}"); //Выводим результат в консоль
