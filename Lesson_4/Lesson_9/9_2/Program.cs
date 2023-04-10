// Напишите программу, которая будет на вход принимать число и возвращать сумму его цифр.
// Использовать рекурсию.

int SumNumbersCount(int a)
{
  if(a < 10) return a;
  return SumNumbersCount(a/10) + a%10;
}
Console.WriteLine("==================");
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {a} равна -> {SumNumbersCount(a)}.");
Console.WriteLine("==================");