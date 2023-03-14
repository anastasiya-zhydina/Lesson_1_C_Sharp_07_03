// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

int GenerateNumber()
{
  int number = new Random().Next(10, 100);
  return number;
}

int GetSecondDigit(int n)
{
  return n%10;
}

int GetFerstDigit(int n)
{
  return n/10;
}

int FindMax(int n1, int n2)
{
  if (n1>n2)
  {
    return n1;
  }
  return n2;
}

void PrintNumber(int n)
{
  Console.WriteLine("Максимальное число: " + n);
}

int num = GenerateNumber();
PrintNumber(num);
int digit1 = GetFerstDigit(num);
int digit2 = GetSecondDigit(num);
int max = FindMax(digit1, digit2);
PrintNumber(max);