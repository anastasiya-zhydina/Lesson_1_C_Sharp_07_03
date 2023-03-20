// Напишите программу, которая принимает на вход число N и выдает
// произведение чисел от 1 до N.

int num = GetUserNumber();
int digit = MultiplyNumbers(num);
Console.WriteLine("Факториал введенного числа: " + digit);

int GetUserNumber()
{
  int number = 0;
  while (number == 0)
  {
    Console.Write("Пожалуйста, введите число: ");
    number = int.Parse(Console.ReadLine()!);
  }
  return number;
}

int MultiplyNumbers(int n)
{
  int multi = 1;
  for(int i = 1; i <= n; i++)
  {
    multi = multi * i;
  }
  return multi;
}