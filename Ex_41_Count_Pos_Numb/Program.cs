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