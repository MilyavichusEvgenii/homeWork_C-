/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

void GetNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {a} в степени {b} равняется {result}");


}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите числовое значение степени");
int value = int.Parse(Console.ReadLine() ?? "");
GetNumber(number, value);