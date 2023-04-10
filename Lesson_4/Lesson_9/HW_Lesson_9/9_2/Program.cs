// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

void PrintNumbers(int m, int n)
{
  if (m > n) return;
  PrintNumbers(m, n - 1);
  Console.Write($"{n} ");
}

int SumNumbers(int m, int n)
{
  if (m == 0) return (n * (n + 1)) / 2;
  else if (n == 0) return (m * (m + 1)) / 2;
  else if (m == n) return m;
  else if (m < n) return n + SumNumbers(m, n - 1);
  else return n + SumNumbers(m, n + 1);
}

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Результат: ");
PrintNumbers(m, n);
Console.WriteLine();
Console.WriteLine($"Сумма всех натуральных чисел в диапазоне между числами {m} и {n} равна: {SumNumbers(m,n)}");

