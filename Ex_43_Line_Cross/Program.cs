// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите угловой коэффициент первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите угловой коэффициент второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите свободный член второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

if (k1 == k2 && b1 == b2) 
{
    x = new Random().Next(0, 10);
    y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} совпадают и имеют бесконечное количество точек пересечения!");
    Console.WriteLine($"Например: ({x};{y})");
}
else if (k1 == k2) 
{
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} параллельны и не имеют точек пересечения!");
    Console.WriteLine("Так сказал Евклид!");
}
else
{
    x = Math.Round((b2 - b1) / (k1 - k2), 2);
    y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} пересекаются!");
    Console.WriteLine($"Точка пересечения: ({x};{y})");
}