/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */




double ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Product(double a, double b, double c, double d)
{
    double x = (c - a) / (b - d);
    double y = b * x + a;
    Console.WriteLine($"({x},{y})");
}

double b1 = ReadInput("Введите b1: ");
double k1 = ReadInput("Введите k1: ");
double b2 = ReadInput("Введите b2: ");
double k2 = ReadInput("Введите k2: ");
Product(b1, k1, b2, k2);