/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int GetNum(string massage)
{
    int result = 0;
    Console.WriteLine(massage);
    if(int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0){
        result = number;
    }
    return result;
}

void ArrRend(int[] array){

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
}

void PrintArr(int[] array)
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

int SumArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 1 || i % 2 != 0){
            result = result + array[i];
        }
        
    }
    return result;
}

int n = GetNum("Введите длину массива");
int[] arrNumb = new int[n];
ArrRend(arrNumb);
int sum = SumArray(arrNumb);
PrintArr(arrNumb);
Console.WriteLine();
Console.WriteLine($"Сумма чисел нечетных индексов массива равна {sum}");
