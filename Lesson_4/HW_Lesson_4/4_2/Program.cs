// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int num = GetUserNumber();
int num1 = Function1(num);
// int num1 = Function1(GetUserNumber());
Console.WriteLine("Сумма цифр введенного числа: " + num1);

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

int Function1(int num)
{
  int sum = 0;
  while (num > 0)
  {
    sum = sum + num % 10;
    num = num / 10;
  }
  return sum;
}