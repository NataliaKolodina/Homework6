// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
int B1 = InputNum("Введите число b1: ");
int K1 = InputNum("Введите число k1: ");
int B2 = InputNum("Введите число b2: ");
int K2 = InputNum("Введите число k2: ");
Console.WriteLine(
    $"b1 = {B1}, k1 = {K1}, b2 = {B2}, k2 = {K2} -> ({FoundX(B1, B2, K1, K2)}; {FoundY(K1, B1, FoundX(B1, B2, K1, K2))})"
);

int InputNum(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!)!;
    return res;
}

double FoundX(int b1, int b2, int k1, int k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return Math.Round(x, 1);
}

double FoundY(int k1, int b1, double x)
{
    double y = k1 * x + b1;
    return Math.Round(y, 1);
}
