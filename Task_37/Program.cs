//Задача 63: Задайте значение N. Напишите программу, 
//которая выведет все значения от 1 до N

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

//по порядку
// void NaturalNumbers(int num)
// {
//     if (num == 0) return; //выход из метода в воид
//     NaturalNumbers(num-1);
//     Console.Write($"{num} ");
// }

//в обратном порядке. Хвостовая рекурсия - 
//когда рекурсивный вызов стоит в конце. 
//Равносильно обычному циклую.
void NaturalNumbers(int num)
{
    if (num == 0) return; //выход из метода в воид
    Console.Write($"{num} ");
    NaturalNumbers(num-1);
}

//Все дополнительные действия выполняются после того 
//как выполнятся все рекурсивные вызовы

