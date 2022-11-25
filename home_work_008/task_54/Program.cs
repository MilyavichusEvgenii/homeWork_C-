
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] ArrayRand()
{
    int[,] tempArray = new int[4,4];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i,j] = rnd.Next(1, 10);
        }
    }
    return tempArray;
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

void ArrangeArr(int[,] array, int a)
{
    if(a == array.GetLength(1)){
        return;
    }
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j + 1 < array.GetLength(1); j++)
        {
            if(array[a,i] > array[a,j])
            {
                temp = array[a,i];
                array[a,i] = array[a,j];
                array[a,j] = temp;
            }
            ArrangeArr(array, a + 1); 
        }
    }

}
int a = 0;
int[,] arrayNumb = ArrayRand();
PrintArray(arrayNumb, "Несортированный массив");
ArrangeArr(arrayNumb, a);
PrintArray(arrayNumb, "Сортированный массив");
