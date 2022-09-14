// Math.Sqrt() //формула извлечения корня

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Enter the coordinates of the first point: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates of the second point: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Gip(int a1, int b1, int a2, int b2)
{
    int doublex = (a1-a2)*(a1-a2);
    int doubley = (b1-b2)*(b1-b2);
    return Math.Sqrt(doublex + doubley);
}
double result = Gip(x1,y1,x2,y2);
Console.WriteLine(Math.Round(result,2, MidpointRounding.ToZero)); //Math.Round функция округления с параметром 2 (до двух знаков после запятой), To Zero - как написано

