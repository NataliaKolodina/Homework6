// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double B1 = InputNum("Введите число b1: ");
double K1 = InputNum("Введите число k1: ");
double B2 = InputNum("Введите число b2: ");
double K2 = InputNum("Введите число k2: ");

Console.WriteLine(
    $"b1 = {B1}, k1 = {K1}, b2 = {B2}, k2 = {K2} -> ({FoundX(B1, B2, K1, K2)}; {FoundY(K1, B1, FoundX(B1, B2, K1, K2))})"
);

double InputNum(string message)
{
    Console.Write($"{message}: ");
    double res = double.Parse(Console.ReadLine()!)!;
    return res;
}

double FoundX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return Math.Round(x, 1);
}

double FoundY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return Math.Round(y, 1);
}
