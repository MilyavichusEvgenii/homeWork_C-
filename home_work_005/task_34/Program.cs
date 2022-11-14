/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/



int GetNumber(string massage)
{
    Console.WriteLine(massage);
    int result = 0;
    if(int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0){
        result = number;
    }
    return result;   
}

void ArrRand(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

void ArrPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1){
            Console.Write($"{array[i]}, ");
        } else {
            Console.Write($"{array[i]}");
        }
    }
}

int CountPossitivNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0){
            count++;
        }
    }
    return count;
}

int n = GetNumber("Введите длину массива");
int[] numb = new int[n];
ArrRand(numb);
int countPossitive = CountPossitivNumb(numb);
ArrPrint(numb);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {countPossitive}.");


