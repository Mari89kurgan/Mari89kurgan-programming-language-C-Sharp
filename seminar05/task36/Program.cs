//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}


int OddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());

int[] myArray = GetArray(x);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {OddSum(myArray)}");
