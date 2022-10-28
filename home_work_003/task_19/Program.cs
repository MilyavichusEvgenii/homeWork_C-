
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

int GetNumber(string massage)
{
    int result;
    while (true)
    {   
        Console.WriteLine(massage);
        

        if(int.TryParse(Console.ReadLine(), out int number) && number >= 10000 &&  number < 100000 || number <= -10000 && number > -100000){
            result = number;
            break;
        } else {
            Console.WriteLine("Вы ввели неверное значение");
        }
    }
    
    return result;

}

int NumbCount(int a)
{
    int len = a / 10;

    int count = 1;

    int value = 0;

    for(int i = 1; i < len; i++){
        
        
        if(a <= count){
            value = i;
            break;
            
        }
        count = count * 10;
    } 

    return count / 10;

}


int ValueCount(int a)
{
    int count = 0;
    int temp = a * 10;

    while(temp >= 9){

        temp = temp / 10;
        count = count + 1;
    }

    return count;
}

void GetValueNum(int a, int b, int c, int[] array)
{
    int e = 0;
    int count = b;
    for(int i = 0; i <= c; i++){
        
        if(a < 10){
            array[i] = a;
            break;
        }
        
        int num = a / count;
        array[i] = num;
        e = num;
        a = a - num * count;
        count = count / 10;
        
    }
    //Console.WriteLine($"{count} {a} {e} {count1}");
}
void ArrayCheck(int[] array, int number)
{
    for(int i = 0; i < array.Length / 2; i++){

       if(array[i] != array[array.Length - 1 - i]){
        Console.WriteLine($"Это число {number} не является полиндромом");
        break;
       } else if(i == 1){
        Console.WriteLine($"Число {number} является полиндромом");
        }
    }
       
    




}

int number = GetNumber("Введите пятизначное число");
int numberMod = Math.Abs(number);
int count = NumbCount(numberMod);
int size = ValueCount(count);
int[] arrayNumb = new int[size];
GetValueNum(numberMod, count, size, arrayNumb);
ArrayCheck(arrayNumb, number);


