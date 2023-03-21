// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = MakeArray();
PrintArray(array);

int GenerateNumbers()
{
  Random rnd = new Random();
  int value =rnd.Next();
  return value;
}

int[] MakeArray()
{
  int[] arr = new int[8];
  for(int i = 0; i < 8; i++)
  {
    arr[i]=  GenerateNumbers();
  }
  return arr;
}

void PrintArray(int[] array)
{
  Console.Write("[ ");
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.Write("]");
}