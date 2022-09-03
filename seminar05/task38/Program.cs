// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(1, 10) + new Random().NextDouble(), 2);
    }
    return array;
}


double MinElem(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


double MaxElem(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

Console.Write("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());

double[] myArray = GetArray(x);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine($"Максимальное значение = {MaxElem(myArray)}, минимальное значение = {MinElem(myArray)}");
Console.WriteLine($"Разница между max и min значением: {Math.Round(MaxElem(myArray) - MinElem(myArray), 2)}");
