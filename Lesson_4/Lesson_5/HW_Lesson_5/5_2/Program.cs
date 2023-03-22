// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

Console.Write("Кол-во элементов: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int max = int.Parse(Console.ReadLine()!);

int[] arr = GenerateArray(length, min, max);
PrintArray(arr);
int num = SumElements(arr);
Console.WriteLine("Сумма чисел на нечетных позициях в массиве: " + num);

int[] GenerateArray(int length, int min, int max)
{
  int[] arr = new int[length];
  for (int i = 0; i < length; i++)
  {
    arr[i] = new Random().Next(min, max + 1);
  }
  return arr;
}

int SumElements(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 == 0)
    {
      sum = sum + arr[i];
    }
  }
  return sum;
}

void PrintArray(int[] arr)
{
  int len = arr.Length;
  for (int i = 0; i < len; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}