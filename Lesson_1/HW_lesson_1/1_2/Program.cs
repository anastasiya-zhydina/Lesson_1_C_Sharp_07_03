// Напишите программу, которая принимает на вход три числа и выдает максимальное из них.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b)
{
  if (a > c)
  {
    Console.Write("Максимальное число = " + a);
  }
  else
  {
    Console.Write("Максимальное число = " + c);
  }
}
else
{
  if (b > c)
  {
    Console.Write("Максимальное число = " + b);
  }
  else
  {
    Console.Write("Максимальное число = " + c);
  }
}
