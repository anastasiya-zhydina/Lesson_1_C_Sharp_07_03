// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N при помощи рекурсии.

void PrintNumbers(int n)
{
  if(n==0) return;
  PrintNumbers(n-1);
  Console.Write($"{n} ");
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Результат: ");
PrintNumbers(n);