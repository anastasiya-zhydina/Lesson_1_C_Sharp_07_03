// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);

int FerstFunction(int n)
{
  return n/10;
}

int SecondFunction(int n)
{
  return n%10;
}

void PrintNumber(int n)
{
  Console.WriteLine("Значение второго числа в трехзначном: " + n);
}

int num1 = FerstFunction(a);
int num2 = SecondFunction(num1);
PrintNumber(num2);