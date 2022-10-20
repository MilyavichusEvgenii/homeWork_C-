/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int GetNum(int a)
{
    while (a < 100 && a > 999 || a > -100 && a < - 999)
    {
        Console.WriteLine("Вы ввели неверное число");
        a = int.Parse(Console.ReadLine() ?? "");
    }
    return a;  
}
int SecNun(int num)
{
    int tempNum = num % 100;
    int secondNum = tempNum / 10;
    if(secondNum < 0)
    {
        secondNum = secondNum * -1;
    }
    return secondNum;

}

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine() ?? "");
int mathNum = GetNum(number);
int meaning = SecNun(mathNum);
Console.WriteLine($"Вторая цифра {meaning} трехзначного числа {number}");
