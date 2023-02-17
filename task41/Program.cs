// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());
int[] arr = GetArray(m);
PrintArray(arr);
Console.Write($" -> {Counter(arr)}");

int InputNum(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = InputNum("Введите число: ");
    }
    return result;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]}, ");
    }
}

int Counter(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
            count++;
    }
    return count;
}
