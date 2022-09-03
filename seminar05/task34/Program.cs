// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}


int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());

int[] myArray = GetArray(x, 100, 1000);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers(myArray)}");
