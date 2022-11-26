/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int GetAddNum(string massage)
{
    Console.WriteLine(massage);
    int result = 0;
    while (true)
    {
        if(int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0)
        {
            result = number;
            break;
        }
    }
    return result;
}

int[,,] InitArray(int a)
{
    int[,,] tempArr = new int[a,a,a];
    Random rnd = new Random();
    for (int i = 0; i < tempArr.GetLength(0); i++)
    {
        for (int j = 0; j < tempArr.GetLength(1); j++)
        {
            for (int k = 0; k < tempArr.GetLength(2); k++)
            {
                tempArr[i,j,k] = rnd.Next(10, 50) + rnd.Next(10, 41) + rnd.Next(1, 10);
            }
        }
    }
    return tempArr;
}

void PrintArray(int[,,] array, string massage)
{
    Console.WriteLine(massage);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int size = GetAddNum("Введите размер трехмерного массива");
int[,,] arrayNumb = InitArray(size);
PrintArray(arrayNumb, "Массив чисел");