/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/




double GetNumber(string massage)
{
    Console.WriteLine(massage);
    double.TryParse(Console.ReadLine(), out double number);
    double result = number;
    
    
    return result;
}

Value GetValue(string massage)
{
    Console.WriteLine(massage);
    Value function = new Value();
    function.K = GetNumber("Введите параметр k");
    function.B = GetNumber("Введите параметр b");

    return function;
}

(double, double) FunctKB(Value firstFunct, Value secondFunct)
{

    double resultX = 0;
    double resultY = 0;
    double k = firstFunct.K - secondFunct.K;
    double b = firstFunct.B - secondFunct.B;
    resultX = - (b / k);
    resultY = firstFunct.K * resultX + firstFunct.B;

    return (resultX, resultY);
}

Value firstParam = GetValue("Введите параметры первой функции y = Kx + b");
Value secondParam = GetValue("Введите параметры второй функции y = Kx + b");
(double x, double y) = FunctKB(firstParam, secondParam);
Console.Write($"Точка пересечения двух функци равна (x: {x}, y: {y})");

class Value
{
    public double K { get; set; }
    public double B { get; set; }
}