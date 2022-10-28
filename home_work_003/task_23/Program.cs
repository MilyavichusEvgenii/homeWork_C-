

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


void MathGetNumber(int a, int b, int[] array)
{

    for (int i = 1; i <= a; i++)
    {
        int temp = i * i * i;
        if(b < 0) {
            array[i - 1] = temp * -1;
        Console.WriteLine($"Куб числа {-i} равняется {array[i-1]}");
        } else if(b >0){

            array[i - 1] = temp;
        Console.WriteLine($"Куб числа {i} равняется {array[i-1]}");
        }
        
    }





}


Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ?? "");
int size = Math.Abs(numb);
int[] arrayNumb = new int[size];
MathGetNumber(size, numb, arrayNumb);
