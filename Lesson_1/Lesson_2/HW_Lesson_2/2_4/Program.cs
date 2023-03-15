// Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа.

string FunctionNum(int num)
{
  if ((-1000<num && num>-99) || (num<1000 && num>99))
  {
    return $"{num} - {num/100*10 + num%10}";
  }
  return "Данное число не является трехзначным.";
}

int val = int.Parse(Console.ReadLine()!);
string result = FunctionNum(val);
Console.WriteLine(result);