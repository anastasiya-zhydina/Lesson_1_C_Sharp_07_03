// Напишите программу, которая принимает на вход координаты точки (X, Y),
// причем X != 0, Y != 0 и выдает номер четверти плоскости, в которой
// находится эта точка.

void Quaters(int x, int y)
{
  if (x == 0 || y == 0)
  {
    Console.WriteLine("x =0, y = 0");
  }
  else if (x>0 && y>0)
  {
    Console.WriteLine("Координаты в I четверти.");
  }
  else if (x<0 && y>0)
  {
    Console.WriteLine("Координаты во II четверти.");
  }
  else if (x<0 && y<0)
  {
    Console.WriteLine("Координаты в III четверти.");
  }
  else if (x>0 && y<0)
  {
    Console.WriteLine("Координаты в IV четверти.");
  }
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quaters(num1, num2);
