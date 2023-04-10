// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
}

int[] SumRow(int[,] matrix)
{
  int row = matrix.GetLength(0);
  int column = matrix.GetLength(1);
  int[] sum_row = new int[row];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      sum_row[i] += matrix[i, j];
    }
  }
  return sum_row;
}

void ComparisonSum(int[] sum_row)
{
  int min = 0;
  for (int i = 1; i < sum_row.Length; i++)
  {
    if (sum_row[i] < sum_row[min])
      min = i;
  }
  Console.Write($"В строке: {min + 1} сумма элементов: {sum_row[min]}.");
}

Console.Write("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix = MassNums(row_num, column_num, start, stop);
PrintArray(matrix);
Console.WriteLine();
int[] sum = SumRow(matrix);
ComparisonSum(sum);
