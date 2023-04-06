/* Задайте двумерный массив.
   Найдите элементы, у которых обе позиции четвные, и замените эти элементы на 
   их квадраты.*/

int[,] MassNums(int row, int column, int from, int to)
{
  int[,] matrix = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      matrix[i,j] = new Random().Next(from, to + 1);

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
  Console.WriteLine();  
}

int[,] Array(int[,] matrix)
{
  for (int i = 1; i < matrix.GetLength(0); i+=2)
    for (int j = 1; j < matrix.GetLength(1); j+=2)
      matrix[i,j] *= matrix[i,j];

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

int[,] matrix1 =  MassNums(row_num, column_num, start, stop);
PrintArray(matrix1);
Array(matrix1);
PrintArray(matrix1);