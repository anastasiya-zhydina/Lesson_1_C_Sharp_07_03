/*  Запишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int[,] MassNums(int row, int column, int from, int to)
{
  int[,] matrix = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      matrix[i, j] = new Random().Next(from, to + 1);

  return matrix;
}

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

Console.Write("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix1 = MassNums(row_num, column_num, start, stop);
PrintArray(matrix1);
//---------------------------------------------------------------
Console.Write("Введите позицию строки: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию столбца: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write(FindNum(matrix1, n, m));

string FindNum(int[,] matrix, int x, int y)
{
  int row_n = matrix.GetLength(0);
  int column_n = matrix.GetLength(1);

  if (x > row_n || y > column_n) return $"Числа с координатами {x} и {y} нет.";
  else
  {
    for (int i = 0; i < row_n; i++)
    {
      for (int j = 0; j < column_n; j++)
      {
        if (i == (x-1) && j == (y-1)) return $"По искомым координатам [{x}, {y}] находится число: {matrix[i, j]}.";
      }
    }
    return $"Числа с координатами {x} и {y} нет.";
  }
}