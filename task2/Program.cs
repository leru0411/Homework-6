// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//формула нахождения точки пересечения: x = (b2-b1)/k1-k2
double Prompt(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine());
}
double b1 = Prompt("Введите точку b1: ");
double k1 = Prompt("Введите точку k1: ");
double b2 = Prompt("Введите точку b2: ");
double k2 = Prompt("Введите точку k1: ");

System.Console.WriteLine($"Точка пересения двух прямых равна {(b2-b1)/(k1-k2)}");