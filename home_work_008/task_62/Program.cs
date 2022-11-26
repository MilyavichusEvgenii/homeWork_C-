/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

void PrintArray(int[,] array, string massage)
{
    Console.WriteLine(massage);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > 9){
                Console.Write($"{array[i,j]} ");
            } else {
                Console.Write($"{array[i,j]}  ");
            }
           
        }
        Console.WriteLine();
    }
}
void StepArrStep(int[,] array, int right, int down, int count)
{
    if(right > array.GetLength(1) - 1 || down > array.GetLength(0) - 1 || right < 0 || down < 0){
        return;
    } else if(array[right,down] == 0){
        count = count + 1;
        array[right, down] = count;
        StepArrStep(array, 0, down + 1, count);
        StepArrStep(array, right + 1, array.GetLength(0) - 1, count);
        StepArrStep(array, array.GetLength(0) - 1, down - 1, count);
        StepArrStep(array, right - 1, 0, count);
        StepArrStep(array, 1, down + 1, count);
        StepArrStep(array, right + 1, 2, count);
        StepArrStep(array, 2, down - 1, count);
    } 
}

int[,] arrayNumb = new int[4,4];
int right = 0;
int down = 0;
int count = 0;
PrintArray(arrayNumb, "Пустой массив");
StepArrStep(arrayNumb, right, down, count);
Console.WriteLine();
PrintArray(arrayNumb, "Заполненный массив");
