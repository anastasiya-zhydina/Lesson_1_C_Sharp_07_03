// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= n)
{
  if (n < 0)
  {
    Console.Write("Необходимо вводить положительные целые числа.");
  }
  else
  {
    if (count % 2 == 0)
    {
      Console.Write(count + " ");
    } 
    count++;
  }
} 
