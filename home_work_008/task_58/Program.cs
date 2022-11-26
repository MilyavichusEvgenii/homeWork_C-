/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/ 

int GetSize(string massage)
{
    Console.WriteLine(massage);
    int result = 0;
    while (true)
    {
        if(int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0){
            result = number;
            break;
        }
    }
    return result;
}

(int[,], int[,]) NumbersMatrixRand(int a)
{
    int[,] matrixA = new int[a,a];
    int[,] matrixB = new int[a,a];
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < a; j++)
        {
            matrixA[i,j] = rnd.Next(1, 10);
            matrixB[i,j] = rnd.Next(1, 10);
        }
    }
    return (matrixA, matrixB);
}

void PrintArray(int[,] array, string massage)
{
    Console.WriteLine(massage);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplMatrixArr(int[,] arrayA, int[,] arrayB, int[,] result, int a)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                result[i,j] = result[i,j] + arrayA[i,k] * arrayB[k,j];
            }  
        }
    }
    

}

int a = 0;
int size = GetSize("Введите размер двух квадратных матриц");
int[,] resultArr = new int[size,size];
(int[,] matrixA, int[,] matrixB) = NumbersMatrixRand(size);
PrintArray(matrixA, "Матрица A");
PrintArray(matrixB, "Матрица B");
MultiplMatrixArr(matrixA, matrixB, resultArr, a);
PrintArray(resultArr, "Матрица A X B");
