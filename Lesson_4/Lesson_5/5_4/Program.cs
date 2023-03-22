// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

int arrLength = 6; //GetUserNumber("array length");
int arrMin = 0; //GetUserNumber("min element");
int arrMax = 10; //GetUserNumber("max element");

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray(arr);
int[] pairsArr = MultiPlairs(arr);
PrintArray(pairsArr);
//Console.WriteLine(CountNumbers(arr));

int[] MakeArray(int length, int min, int max)
{
  int[] arr = new int[length];
  for (int i = 0; i < length; i++)
  {
    arr[i] = new Random().Next(min, max + 1);
  }
  return arr;
}

void PrintArray(int[] array)
{
  int len = array.Length;
  for (int i = 0; i < len; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
/*
int CountNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] <= 99)
    {
      count++;
    }
  }
  return count;
}
*/
int[] MultiPlairs(int[] array)
{
  arrLength = array.Length;
  int[] pairs = new int[arrLength/2 + arrLength%2];

  for(int i = 0; i <arrLength/2; i++)
  {
    pairs[i] = array[i] * array[arrLength - i - 1];
  }

  if(arrLength%2 == 1)
  {
    pairs[pairs.Length - 1] = array[arrLength/2];
  }
  return pairs;
}