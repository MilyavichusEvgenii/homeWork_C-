/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if(int.TryParse(Console.ReadLine() ?? "", out int number) && number > 0){
            result = number;
            break;
        } 
    }
    return result;
    
}

string RecNumbStr(int a)
{
    string result = string.Empty;
    if(a == 1){
        return a.ToString();
    } else {
        return a + " " + RecNumbStr(a - 1);
    }
}


int number = GetNumber("Введите число");
string numberStr = RecNumbStr(number);
Console.WriteLine($"Натуральные числа ({numberStr}) в промежутке от {number} до 1");