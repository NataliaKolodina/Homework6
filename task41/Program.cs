// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());
AddNums(m);

int[] AddNums(int[] array, M)
{
    for(int i = 1; i <= M; i++)
    {
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    Console.Write($"{num}, ");
    }
    return num;
}
