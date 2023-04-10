// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void PrintNumbers(int m, int n)
{
  if (m > n) return;

  if (n % 2 == 0)
  {
    PrintNumbers(m, n - 2);
  }
  else
  {
    PrintNumbers(m, n - 1);
  }

  if(n%2 == 0)
    Console.Write($"{n} ");

}

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Результат: ");
PrintNumbers(m, n);