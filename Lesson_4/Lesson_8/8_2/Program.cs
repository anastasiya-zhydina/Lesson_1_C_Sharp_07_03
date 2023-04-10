// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
      Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
  }
}

int[,] MassNums(int row, int column, int from, int to)
{
  int[,] matrix = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      matrix[i, j] = new Random().Next(from, to + 1);

  return matrix;
}

int[] CountFreequensy(int[,] matrix, int max)
{
  int row_size = matrix.GetLength(0);
  int column_size = matrix.GetLength(1);
  int[] frequencies = new int[max + 1];

  foreach (int elem in matrix)
  {
    frequencies[elem]++;
  }
  return frequencies;
}

void PrintFrequencies(int[] matrix)
{
  for (int i = 0; i < matrix.Length; i++)
  {
    Console.WriteLine($"Количество {i} -> {matrix[i]}");
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

int[,] matrix = MassNums(row_num, column_num, start, stop);
PrintArray(matrix);
Console.WriteLine();
int[] freq = CountFreequensy(matrix, stop);
PrintFrequencies(freq);

