// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int mist = 0;
string m = string.Empty;
int count = 0;
while (mist == 0)
{
    try
    {
        Console.Write("Введите число или s для окончания ввода: ");
        m = Console.ReadLine();
        if (m == "s") break;
        int noun = Convert.ToInt32(m);
        if (noun > 0) count++;
    }
    catch
    {
        Console.WriteLine("Ошибочный ввод!");
    }
}
Console.WriteLine($"Введенных чисел больше нуля: {count}.");