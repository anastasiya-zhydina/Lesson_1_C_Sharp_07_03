// Напишите программу, которая принимает на вход число N, а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = -n;

while (count != n)
{
  Console.Write(count + " ");
  if (n < 0)
  {
    count--;
  }
  else
  {
    count++;
  }
}
