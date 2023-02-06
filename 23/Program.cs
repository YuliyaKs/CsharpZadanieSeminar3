// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
if (N < 0)
{
    i = N;
    N = -1; 
}

for (; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
