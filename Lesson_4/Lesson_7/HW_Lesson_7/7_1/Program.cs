// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

/*
double[] GenerateArray(int length, int minArr, int maxArr)
{
  double[] arr = new double[length];
  Random n_new = new Random();

  for (int i = 0; i < length; i++)
  {
    arr[i] = Math.Round(n_new.NextDouble()*(maxArr - minArr) + minArr, 2);
  }
  return arr;
}
*/

double[,] MassNums(int row, int column, int from, int to)
{
  double[,] matrix = new double[row, column];
  Random n_new = new Random();

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      matrix[i,j] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);

  return matrix;
}

Console.Write("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

double[,] matrix =  MassNums(row_num, column_num, start, stop);
PrintArray(matrix);