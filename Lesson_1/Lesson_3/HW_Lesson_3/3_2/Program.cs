// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое положитльное число: ");
int num = int.Parse(Console.ReadLine()!);

void MyFunction(int a)
{
  if (a<=0)
  {
    Console.WriteLine("Введите ПОЛОЖИТЕЛЬНОЕ число, отличное от 0!");
  }
  else
  {
    for (int i = 1; i <= a; i++)
  {
    Console.WriteLine(Math.Pow(i,3));
  }
  }
}

Console.WriteLine();
MyFunction(num);