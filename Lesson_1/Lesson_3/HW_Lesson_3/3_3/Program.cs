﻿// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);

void Function(int a)
{
  if ((a > 9999 && a < 100000) || (a > -100000 && a < -9999))
  {
    if (a / 10000 == a % 10 && a / 1000 % 10 == a / 10 % 10)
    {
      Console.Write("Введенное число является палиндромом.");
    }
    else
    {
      Console.Write("Введенное число не является палиндромом.");
    }
  }
  else
  {
    Console.Write("Введенное число не укладывается в заданный диапазон пяти цифр.");
  }
}

Function(a);