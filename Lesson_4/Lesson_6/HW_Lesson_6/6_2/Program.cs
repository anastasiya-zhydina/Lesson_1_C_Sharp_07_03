/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("k1 = ");
int k1 = int.Parse(Console.ReadLine()!);

Console.Write("b1 = ");
int b1 = int.Parse(Console.ReadLine()!);

Console.Write("k2 = ");
int k2 = int.Parse(Console.ReadLine()!);

Console.Write("b2 = ");
int b2 = int.Parse(Console.ReadLine()!);

Print(k1, b1, k2, b2);

void Print(int k1, int b1, int k2, int b2)
{
  //(k1*x) - (k2*x) = b2 - b1;
  int x;
  int y;

  x = (b2-b1)/(k1-k2);
  y = (k1*x) + b1;

  Console.Write($"Точка пересечения прямых по заданным координатам: {x}; {y}.");
}