/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int GetNumb(string massage)
{
    Console.WriteLine(massage);
    int.TryParse(Console.ReadLine() ?? "", out int number);
    return number;
    
}

int[,] ArrayIntRand()
{
    int[,] array = new int[5, 5];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 31);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void CheckNumb(int[,] array, int numb)
{
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == numb){
                a = 1;
            } 
        }
    }
    if(a == 1){
        Console.WriteLine($"Значение {numb} принадлежит массиву");
    } else {
        Console.WriteLine($"Значение {numb} отсутствует в массиве");
    }
}

int number = GetNumb("Введите искомое значение от 1 до 30");
Console.WriteLine("Массив чисел:");
int[,] arrNumb = ArrayIntRand();
PrintArray(arrNumb);
CheckNumb(arrNumb, number);

