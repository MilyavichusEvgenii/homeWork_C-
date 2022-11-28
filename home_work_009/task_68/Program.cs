/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string massage)
{
    Console.WriteLine(massage);
    int result = 0;
    while (true)
    {
        if(int.TryParse(Console.ReadLine() ?? "", out int number) && number >= 0){
            result = number;
            break;
        }
    }
    return result;
}

int GetNumbAkсRec(int m, int n)
{
    if(m == 0){
        return n + 1;
    } else if(m > 0 && n == 0){
        return GetNumbAkсRec(m - 1, 1);
    } else {
        return GetNumbAkсRec(m - 1, GetNumbAkсRec(m, n - 1));
    }
    
}

int m = GetNumber("Введите параметр M");
int n = GetNumber("Введите параметр n");
double funAkс = GetNumbAkсRec(m, n);
Console.WriteLine($"Функция Аккермана от входных параметров {m} и {n} равняется {funAkс}");