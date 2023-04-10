// Напишите программу, которая на вход принимает два числа А и В, и возводит число А
// в целую степень В с помощью рекурсии.

double Exponentiation(int a, int b)
{
  if(b>0) return Exponentiation(a, b-1)*a;
  if(b<0)return Exponentiation(a, b+1)*(1/a);
  else return 1;
}

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

double exp = Exponentiation(A,B);
Console.Write($"Число {A} в степени числа {B} даст результат -> {exp}.");
