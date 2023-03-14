// Напишите программу, которая на вход принимает число и выдает, является ли оно четным.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
  Console.Write("Число " + a + " четное.");
}
else
{
  Console.Write("Число " + a + " нечетное.");
}

