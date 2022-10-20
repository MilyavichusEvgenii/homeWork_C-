/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


Console.Clear();
Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if( number1 > number2) {
    Console.WriteLine($"Число {number1} больше, чем число {number2}");
} 
else if (number1 < number2) {
    Console.WriteLine($"Число {number2} больше, чем число {number1}");
}
else if (number1 == number2) {
    Console.WriteLine("Числа равны");
}
