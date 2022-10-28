/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/




void MathLongMetod(int a, int b, int c, int d, int e, int f)
{

    double result = Math.Sqrt(Math.Pow(a - d, 2) + Math.Pow(b - e, 2) + Math.Pow(c - f, 2));
    double answer = Math.Round(result, 2);
    Console.WriteLine($"Расстояние между двумя точками в трехмерном измерении равняется {answer}");


}

Console.WriteLine("Введите x, y, z для первой точки");
int ax1 = int.Parse(Console.ReadLine() ?? "");
int by1 = int.Parse(Console.ReadLine() ?? "");
int cz1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите x, y, z для второй точки");
int dx2 = int.Parse(Console.ReadLine() ?? "");
int ey2 = int.Parse(Console.ReadLine() ?? "");
int fz2 = int.Parse(Console.ReadLine() ?? "");
MathLongMetod(ax1, by1, cz1, dx2, ey2, fz2);