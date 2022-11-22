/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

int GetNumber(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if (int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0)
        {
            result = number;
            break;
        } else {
            Console.WriteLine("Вы ввели число меньше нуля");
        }
    }
    return result;
}

double[,] ArrDoubRend(int lines, int columns)
{
    double[,] array = new double[lines,columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * 10, 2) * rnd.Next(-1, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array, string massage)
{
    Console.WriteLine(massage);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int columns = GetNumber("Введите количество строк");
int lines = GetNumber("Ввведите количество столбцов");
double[,] arrayDoub = ArrDoubRend(columns, lines);
PrintArray(arrayDoub, "Массив случайных вещественных чисел");
