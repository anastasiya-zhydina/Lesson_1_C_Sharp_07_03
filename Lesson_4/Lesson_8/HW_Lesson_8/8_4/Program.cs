// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] MinNumberInMassive(int[,] matrix)
{
  int min_num = matrix[0, 0];
  int[] indexes = new int[2];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (min_num > matrix[i, j])
      {
        min_num = matrix[i, j];
        indexes[0] = i;
        indexes[1] = j;
      }
    }
  }
  Console.WriteLine(matrix[indexes[0], indexes[1]]);
  return indexes;
}

int[,] DeletionRowAndColumn(int[,] matrix, int[] indexes)
{
  int m = 0;
  int n = 0;
  int row = matrix.GetLength(0);
  int column = matrix.GetLength(1);
  int[,] new_matrix = new int[row - 1, column - 1];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      if (indexes[0] != i && indexes[1] != j)
      {
        new_matrix[m, n] = matrix[i, j];
        n += 1;
      }
    }
    n = 0;
    if (indexes[0] != i) m += 1;
  }
  return new_matrix;
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
Console.WriteLine("-----------");
int[] minimum = MinNumberInMassive(matrix);
int[,] new_matrix = DeletionRowAndColumn(matrix, minimum);
Console.WriteLine("-----------");
PrintArray(new_matrix);