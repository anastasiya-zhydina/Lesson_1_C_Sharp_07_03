// Напишите программу, которая на вход принимает два числа и на выходе выдает, какое большее, какое меньшее.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
  Console.WriteLine("Первое число " + a + " больше второго " + b);
}
else
{
  Console.WriteLine("Второе число " + b + " больше первого "  + a);
}