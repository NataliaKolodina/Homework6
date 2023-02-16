// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());
int[] arr = GetArray(m);
Console.Write(String.Join(", ", arr));
Console.Write($" -> {Counter(arr)}");


int[] GetArray(int num)
{
int [] array = new int[num];
for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(-100, 101);
}
return array;
}

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
