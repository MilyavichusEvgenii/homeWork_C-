/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
for(int i =0; i < 2; i++){
    if(b > max){
        max = b;
    } else if(c > max){
        max = c;
    } 
}
Console.WriteLine($"Максимальным числом из трех чисел является {max}");

