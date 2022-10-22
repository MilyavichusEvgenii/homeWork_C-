 /*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/

int EnterMethodNum(int a)
{

    if(a > 7 || a < -7){
        a = a % 7;
    }
    return a - 1;
}
int PossitiveNum(int a)
{
    if(a < 0){
        a = Math.Abs(a);
    }
    return a;
}
void OneDayWeek(string[] array, int a)
{
    for(int i = a; i <= 7; i = i + 0){
        string day = array[i];
        string mass = "выходной";
        if(a >= 0 && a <= 4){
            Console.WriteLine($"{array[i]} {i + 1} день недели");
            break;
        } else if(a == 5 || a == 6){
            Console.WriteLine($"{array[i]} {i + 1} день недели, {mass}");
            break;
        }

    }

}



Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "");
int number1 = EnterMethodNum(number);
int number2 = PossitiveNum(number1);
string[] arrayStr = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
OneDayWeek(arrayStr, number2);