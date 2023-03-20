// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты первой точки: x1 = ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты первой точки: y1 = ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты первой точки: z1 = ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты второй точки: x2 = ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты второй точки: y2 = ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты второй точки: z2 = ");
int z2 = int.Parse(Console.ReadLine()!);

double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
  return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
}

Console.WriteLine("Расстояние между точками в пространстве = " + (Length(x1, y1, x2, y2, z1, z2)));