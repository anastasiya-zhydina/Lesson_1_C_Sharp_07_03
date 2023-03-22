// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Количество элементов случайного массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] arr = GenerateArray(size);
PrintArray(arr);
PrintNumbers(arr);

int[] GenerateArray(int size)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(100, 1000);
  return arr;
}

int EvenNumbers(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
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

void PrintNumbers(int[] arr)
{
  int num = EvenNumbers(arr);
  Console.WriteLine("Количество четных чисел в массиве: " + num);
  //Console.Write(EvenNumbers(arr));
}

