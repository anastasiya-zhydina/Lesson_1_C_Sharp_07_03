/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.Write("Введите элементы через пробел: ");

int[] arr = Array.ConvertAll(Console.ReadLine()
                                    .Split(), int.Parse);
int count = arr.Count(x => x > 0);

Console.WriteLine($"Количество элементов больше нуля: {count}.");

//------

//string line = Console.ReadLine();
//string[] splitLine = line.Split(' ');
