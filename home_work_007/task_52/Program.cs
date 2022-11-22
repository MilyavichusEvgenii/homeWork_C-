/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

 int SizeArray()
 {
    int a;
    while (true)
    {
        Console.WriteLine("Введите количество строк массива");
        if(int.TryParse(Console.ReadLine() ?? "", out int numberFirst) && numberFirst > 0)
        {
            a = numberFirst;
            break;
        }
    }
    return a;
 }

 void PrintArray(int[,] array)
 {
    Console.WriteLine("Массив целых чисел");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
 }

 void ArrRend(int[,] array)
 {
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-9, 10);
        }
    }
 }

 (double, double, double, double) SumMathCol(int[,] array, int a)
 {
    double sum0 = 0;
    double sum1 = 0;
    double sum2 = 0;
    double sum3 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0){
                sum0 = sum0 + array[i,j];
            } else if(j == 1){
                sum1 = sum1 + array[i,j];
            } else if(j == 2){
                sum2 = sum2 + array[i,j];
            } else if(j == 3){
                sum3 = sum3 + array[i,j];
            }
        }
    }
    return (sum0 / a, sum1 / a, sum2 / a, sum3 / a);
 }

 int size = SizeArray();
 int[,] arrNumbs = new int[size,4];
 ArrRend(arrNumbs);
 PrintArray(arrNumbs);
 (double col0, double col1, double col2, double col3) = SumMathCol(arrNumbs, size);

 Console.Write($"Среднеарифметическое первого слолбца {col0} \nСреднеарифметическое второго столбца {col1} \n" 
 + $"Среднее арифметическое третьего столбца {col2} \nСреднеарифметическое четвертого столбца {col3}");