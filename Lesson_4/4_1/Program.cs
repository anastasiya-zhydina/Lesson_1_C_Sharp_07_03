// Напишите программу, которая на вход принимает число и выдает
// количество цифр в числе.

int num = GetUserNumber();
int digit = CountNumber(num);
Console.WriteLine("Количесвто цифр в веденном числе: " + digit);

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

int CountNumber(int n)
{
  int count = 0;
  while (n>0)
  {
    n = n/10;
    count++;
  }
  return count;
}