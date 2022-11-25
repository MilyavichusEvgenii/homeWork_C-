/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] GetArrayR()
{
    int[,] tempArr = new int[4,5];
    Random rnd = new Random();
    for (int i = 0; i < tempArr.GetLength(0); i++)
    {
        for (int j = 0; j < tempArr.GetLength(1); j++)
        {
            tempArr[i,j] = rnd.Next(0, 10);
        }
    }
    return tempArr;
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
}

int SummArrValue(int[,] array, int a, int b)
{
    int sum = 0;
    if(a == array.GetLength(1)){
        return sum;
    } else {
        return sum = sum + array[b,a] + SummArrValue(array, a + 1, b);
    }
    
    
}

int[,] IndexValueLines(int[,] array, int a)
{
    int[,] tempArr = new int[array.GetLength(0),2];
    for (int i = 0; i < tempArr.GetLength(0); i++)
    {
        tempArr[i,0] = i + 1;
        tempArr[i,1] = SummArrValue(array, a, i);
        
        
    }

    return tempArr;
}

(int, int) CheckMaxSumm(int[,] array)
{
    int max = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] > max)
            {
                max = array[i,j];
                index = i + 1;
            }
        }
    }
    return (max, index);
}


int[,] arrayNumb = GetArrayR();
int a = 0;
PrintArray(arrayNumb, "Задан массив");
int[,] resultSum = IndexValueLines(arrayNumb, a);
(int max, int index) = CheckMaxSumm(resultSum);
Console.WriteLine($"Строка массива {index} имеет самую большую сумму элементов {max}.");