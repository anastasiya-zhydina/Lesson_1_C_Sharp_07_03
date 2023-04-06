/* Задайте двумерный массив.
Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали
и вертикали, или напишите, что такого элемента нет. */ 

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

Console.Write("Введите искомое число: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write(FindNum(matrix1, n));

string FindNum(int[,] matrix, int x)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      if(matrix[i,j] == x)return $"Искомые координаты числа {x}: [{i + 1}, {j + 1}]";
    }
  }  
  return $"Искомое число {x} в массиве не найдено.";
}