// Напишите программу, которая выводит массив из 8 элемонтов, заполненный нулямии единицами
// в случайном порядке.

int[] array = MakeArray();
PrintArray(array);

int[] MakeArray()
{
  int[] arr = new int[8];
  for(int i = 0; i < 8; i++)
  {
    arr[i]= GenerateNumbers();
  }
  return arr;
}

int GenerateNumbers()
{
  int number = new Random().Next(2);
  return number;
}

void PrintArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}