/* Напишите программу, которая будет создавать копию заданного двумерного массива 
с помощью поэлементного копирования. */

void PrintArray(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MassNums(int size, int size2, int from, int to)
{
  int[,] matrix = new int[size, size2];

  for (int i = 0; i < size; i++)
    for (int j = 0; j < size2; j++)
      matrix[i,j] = new Random().Next(from, to + 1);

  return matrix;
}


int[,] FunctionCopi(int[,] matrix)
{
  int[,] copi = new int[matrix.GetLength(0), matrix.GetLength(1)];

  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
      copi[i,j] = matrix[i,j];
      Console.WriteLine();
  }
  return copi;
}

int[,] matrix =  MassNums(4, 5, 1, 10);
PrintArray(matrix);
PrintArray(FunctionCopi(matrix));