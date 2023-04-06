/* Задайте двумерный массив размера m на n, каждый элемент массива находится по формуле:
A = m+n.
Выведите полученный массив на экран.*/

int[,] MassNums(int row, int column)
{
  int[,] matrix = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      matrix[i,j] = i + j;

  return matrix;
}

void PrintArray(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] matrix =  MassNums(row_num, column_num);
PrintArray(matrix);