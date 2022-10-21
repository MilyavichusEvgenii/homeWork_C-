/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int CheckMath(int a, int[] array)
{
    for(int i =0; i < 1; i++){
        if(a >= 100 || a <= -100){
            break;
        } else if(a < 100 || a > -100){
            array[2] = -1;
        }


    }
    a = Math.Abs(a);
    return a;


}
int MathTask1(int a){
    int step = a / 10;
    int count = 1;
    int result = 0;
    for(int i = 0; i < step; i++) 
    {   
        if(a / count < 10)
        {
            result = i;
            break;

        }

        count = count * 10; 
    }
    return count;
}
void MathTask2(int a, int len, int[] array)
{   int b = a;
    int escNum = 1;
    for(int i = 0; i < 3; i++)
    {
        if(a < 100){
            break;
        } else if(a > 100){
        int numb = b / (len / escNum);
        array[i] = numb;
        
        b = b - numb * (len / escNum);
        }
        escNum = escNum * 10;

    }
    
}
void PrintAnswer(int[] array, int a){

    if(array[2] > 0){
    Console.WriteLine($"{array[2]} цифра третьего разряда числа {a}");
    } else if(array[2] < 0){
        Console.WriteLine($"У числа {a} нет третьего разряда");
    }

}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "");
int[] arrayNumb = new int[3];
int number1 = CheckMath(number, arrayNumb);
int result1 = MathTask1(number1);
MathTask2(number1, result1, arrayNumb);
PrintAnswer(arrayNumb, number);


 

 

  
