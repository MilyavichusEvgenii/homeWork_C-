/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/



int GetNumber(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if(int.TryParse(Console.ReadLine() ?? "", out int number)){
            result = number;
            break;
        }
    }
    return result;
}


string GetRecNumber(int a, int b)
{
    if(a == b){
        return a.ToString();
    } else {
        return a + " " + GetRecNumber(a + 1, b);
    }
}

int rangeA = GetNumber("Введите число M");
int rangeB = GetNumber("Введите число N");
string resultNumbLine = GetRecNumber(rangeA, rangeB);
Console.WriteLine($"Натуральные числа ({resultNumbLine}) в диапазоне от {rangeA} до {rangeB} включительно");
