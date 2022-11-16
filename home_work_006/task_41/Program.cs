
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int[] GetNumber(string massage)
{
    Console.WriteLine(massage);
    string numbSt = Console.ReadLine() ?? "";
    char[] separator = {',', ' '};
    string[] arrSt = numbSt.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    int size = arrSt.Length;
    int[] arrInt = new int[size];
    for (int i = 0; i < size; i++)
    {
        string a = arrSt[i];
        arrInt[i] = Convert.ToInt32(a);
    }

    return arrInt;
}

int CheckNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            result++;
        }
    }
    return result;
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
    Console.WriteLine();
}

int[] numberInt = GetNumber("Введите ряд чисел чере запятую или пробел, или через запятую и пробел");
PrintArr(numberInt);
int result = CheckNum(numberInt);
Console.WriteLine($"{result} - количество цифр больше нуля, которые ввел пользователь.");

