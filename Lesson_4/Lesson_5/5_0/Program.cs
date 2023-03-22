// Задайте массив из 12 элементов, заполните случайными числами из промежутка [-9, 9].
// Найдите сумму + и - элементов массива.

int[] EightMass(int size, int from, int to)
{
	int[] arr = new int[size];
	
	for(int i = 0; i < size; i++)
		arr[i] = new Random().Next(from, to + 1);
	return arr;
}

void Print(int[] arr)
{
	int size = arr.Length;
	
	for(int i = 0; i < size; i++)
		Console.Write($"{arr[i]} ");
	Console.WriteLine();
}

void SumPosNeg(int[] arr)
{
  int pos, neg;
  pos = neg = 0;

  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] >= 0)
      pos += arr[i];
    else
      neg += arr[i];
  }
  Console.WriteLine($"Pos: {pos}, neg: {neg}");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);
SumPosNeg(mass);