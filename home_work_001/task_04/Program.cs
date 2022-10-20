/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

 Console.Clear();
 Console.WriteLine("Введите число");
 int number = int.Parse(Console.ReadLine());
 int a = Math.Abs(number);

 string numbStr = "";
    for(int i = 2; i <= a; i = i + 2)
    {
        if(number < 0){
             numbStr+=-i + " ";
        } else {
            numbStr+=i + " "; 
        }
    }
 Console.WriteLine($"Все четные числа в промежутке от 1 до {number}: {numbStr}");
