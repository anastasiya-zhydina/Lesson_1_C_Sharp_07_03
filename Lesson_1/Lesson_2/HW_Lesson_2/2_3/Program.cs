// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Function(int num)
{
  string text = "Это не день недели.";
  if (num ==7 || num == 6)
  {
    text = "Выходные.";
  }
  else if (num<6 && num>0)
  {
    text = "Рабочийе дни";
  }
  Console.WriteLine(num + " - " + text);
}

int val = int.Parse(Console.ReadLine()!);
Function(val);