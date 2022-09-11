// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        array[i] = number;
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine($"Количество чисел в массиве больше нуля: {PositiveNumbers(GetArray(m))}");
