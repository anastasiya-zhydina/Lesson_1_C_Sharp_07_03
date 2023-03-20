// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x, y).

void GetQuarter()
{
  Console.Write("Пожалуйста, введите номер четверти: ");
  int q = int.Parse(Console.ReadLine()!);
  if (q < 1 || q > 4)
  {
    Console.WriteLine("Такой четверти нет.");
  }
  else
  {
    switch (q)
    {
      case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
      case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
      case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
      case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
      default:
        Console.WriteLine("Такой четверти нет.");
        break;
    }
  }
}

GetQuarter();