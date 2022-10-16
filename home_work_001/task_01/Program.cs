Console.Clear();
Console.WriteLine("Введите первое число ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if( number1 > number2) {
    Console.WriteLine($"Число {number1} больше, чем число {number2}");
} 
if (number1 < number2) {
    Console.WriteLine($"Число {number2} больше, чем число {number1}");
}
if (number1 == number2) {
    Console.WriteLine("Числа равны");
}
