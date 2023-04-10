// Задайте двумерный  массив. Напишите программу, которая поменяет местами первую и последнюю 
// СТРОКУ масства.

void PrintArray(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MassNums(int row, int column, int from, int to)
{
  int[,] matrix = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      matrix[i,j] = new Random().Next(from, to + 1);

  return matrix;
}

void FirstLast(int[,] matrix)
{
  int row_size = matrix.GetLength(0);
  int column_size = matrix.GetLength(1);

  for(int j = 0; j < column_size; j++)
    (matrix[0, j], matrix[row_size - 1, j]) = (matrix[row_size - 1, j], matrix[0, j]);
}

Console.Write("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] matrix =  MassNums(row_num, column_num, start, stop);
PrintArray(matrix);
FirstLast(matrix);
Console.WriteLine();
PrintArray(matrix);