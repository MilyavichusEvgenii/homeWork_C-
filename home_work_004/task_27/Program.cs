/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/


int TryNumb(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine("Введите число");

        if(int.TryParse(Console.ReadLine() ?? "", out int number)){
            result = number;
            break;


        }
    }

    return Math.Abs(result);


}


(int, int) CountNumb(int a)
{
    int i = 1;
    int count = 1;
    while(a > 9){

         i+= 1;
        a = a / 10;

        count*= 10;


    }

    return (count, i);
}

int SumNumbs(int a, int count, int c)
{   
    int sum = 0;
    for (int i = 1; i <= c; i++)
    {
        if(a < 10){
            sum = sum + a;
            break;
        }
        int num = a / count;
        sum = sum + num;
        a = a - num * count;
        count/=10;
    }
     return sum;
}
   
    

int numberInt = TryNumb("Введите число");
(var countNbr, var size) = CountNumb(numberInt);
var summ = SumNumbs(numberInt, countNbr, size);
Console.WriteLine($"Сумма чисел числа {numberInt} равняется {summ}");
