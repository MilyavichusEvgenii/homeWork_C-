
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int GetNumb(string massage)
{
    Console.WriteLine(massage);
    int result = 0;
    if(int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0){
        result = number;
    }
    return result;
}
void DoubleArrRand(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 10, 3);
    }
}

void IntIndexArr(int[] arrayI, double[] arrayD)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayI.Length; i++)
    {
        arrayI[i] = rnd.Next(0, 2);
        if(arrayI[i] == 1){
            arrayD[i] = arrayD[i] * -1;
        }
    }
}

void ArrPrint(double[] array)
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

double DifArrMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
   
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i]){
            max = array[i];
        } else if(min > array[i]){
            min = array[i];
        }
    }
     double result = max - min;
    
    return result;
}

int n = GetNumb("Задайте длину массива");
double[] doubArr = new double[n];
int[] intArray = new int[n];
DoubleArrRand(doubArr);
IntIndexArr(intArray, doubArr);
ArrPrint(doubArr);
double f = DifArrMinMax(doubArr);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным элементом массива составляет {f}");