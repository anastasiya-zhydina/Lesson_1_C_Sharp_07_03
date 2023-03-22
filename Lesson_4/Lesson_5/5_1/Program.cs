// Напишите программу замены элементов массиа:
// + заменитк на - и наоборот.

Console.Write("Количество элементов: ");
int count = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапазона: ");
int b = int.Parse(Console.ReadLine()!);

int[] EightMass(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(from, to + 1);
  return arr;
}

void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();
}

void MyFunction(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
    arr[i] *= -1;
}

int[] array = EightMass(count, a, b);
Print(array);
MyFunction(array);
Console.WriteLine();
Print(array);
