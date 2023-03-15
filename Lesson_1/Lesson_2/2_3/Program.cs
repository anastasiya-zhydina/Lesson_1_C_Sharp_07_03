// Напишите программу, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

void MyFunction(int num)
{
  if (num%7 == 0 && num%23 == 0)
  {
    Console.WriteLine("Число " + a + " кратно 7 и 23 одновременно.");
  }
  else
  {
    Console.Write("Число " + a + " не кратно 7 и 23 одновременно.");
  }
}

MyFunction(a);