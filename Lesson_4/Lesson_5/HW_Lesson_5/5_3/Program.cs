// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Кол-во элементов: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int minArr = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int maxArr = int.Parse(Console.ReadLine()!);

int[] arrey = GenerateArray(length, minArr, maxArr);
Console.WriteLine();
PrintArray(arrey);
int mx = MaxNumbers(arrey);
int mn = MinNumbers(arrey);
Console.WriteLine("max: " + mx);
Console.WriteLine("min: " + mn);
int dif = mx - mn;
Console.WriteLine("Разница между max и min: " + dif);

int[] GenerateArray(int length, int minArr, int maxArr)
{
  int[] arr = new int[length];
  for (int i = 0; i < length; i++)
  {
    arr[i] = new Random().Next(minArr, maxArr + 1);
  }
  return arr;
}

int MinNumbers(int[] arr)
{
  int min = arr[0];
  
  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] < min)
      min = arr[i];
  }
  return min;

}
int MaxNumbers(int[] arr)
{
  int max = arr[0];

  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > max)
      max = arr[i];
  }
  return max;
}

int DifferenceMaxMin(int max, int min)
{
  int number = (max - min);
  return number;
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

