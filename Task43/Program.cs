// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Intersection(b1, k1, b2, k2);

void Intersection(double a1, double c1, double a2, double c2)

{
    double x1 = (a1 - a2) / ((c1 - c2) * -1);
    double x2 = c2 * x1 + a2;
    Console.WriteLine($"({x1}; {x2})");
}
