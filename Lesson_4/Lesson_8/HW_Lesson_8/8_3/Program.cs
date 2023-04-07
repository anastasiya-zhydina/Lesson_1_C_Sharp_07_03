// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] ProductOfMatrix(int[,] matrixA, int[,] matrixB)
{
  int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      matrixC[i, j] = 0;
      for (int n = 0; n < matrixA.GetLength(1); n++)
      {
        matrixC[i, j] += matrixA[i, n] * matrixB[n, j];
      }
    }
  }
  return matrixC;
}

Console.Write("Введите число строк матрицы А: ");
int row_numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов матрицы А: ");
int column_numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение матрицы А: ");
int startA = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число матрицы А: ");
int stopA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число строк матрицы В: ");
int row_numB = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов матрицы В: ");
int column_numB = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение матрицы В: ");
int startB = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число матрицы В: ");
int stopB = int.Parse(Console.ReadLine()!);

if (row_numA != column_numB)
{
  Console.Write("Количество столбцов матрицы А не совпадает с количеством строк матрицы В - произведение матриц не возможно.");
}
else
{
  int[,] matrixA = MassNums(row_numA, column_numA, startA, stopA);
  PrintArray(matrixA);
  Console.WriteLine("-------");
  int[,] matrixB = MassNums(row_numB, column_numB, startB, stopB);
  PrintArray(matrixB);
  Console.WriteLine("-------");
  int[,] matrixC = ProductOfMatrix(matrixA, matrixB);
  PrintArray(matrixC);

}


