// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координату x для первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y для первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z для первой точки: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату x для второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y для второй точки: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату z для второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние между точками равно {distance:f2}");
