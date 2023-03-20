// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int num = Fuction1(a, b);
Console.WriteLine($"Число {a} в степени {b} равно - " + num);

int Fuction1(int a, int b)
{
  int c = 1;
  for(int i = 1; i <= b; i++)
  {
    c = c*a;
  }
  return c;
}

