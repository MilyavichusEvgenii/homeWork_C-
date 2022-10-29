/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();*/



string GetMassage(string massage)
{
    string result;
while (true)
{
    Console.WriteLine(massage);
    string text = Console.ReadLine();
    if(text.Length > 8 || text.Length < 8){
        Console.WriteLine("Вы ввели некорректное количество цифр");
    
    } else {
        result = text;
        break;
    }
}
    return result;
}
var text = GetMassage("Введите 8 натуральных чисел");

int[] array = new int[8];
for(int i = 0; i < 8; i++){

    char a = text[i];
    int b = Convert.ToInt32(a);
    array[i] = b - 48;

}
Console.WriteLine($"Массив чисел равняется: {String.Join(",", array)}");