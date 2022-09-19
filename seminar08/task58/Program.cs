// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}



int[,] productArr(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}

int[,] array = GetArray(2, 2);
PrintArray(array);
Console.WriteLine();
int[,] array2 = GetArray(2, 2);
PrintArray(array2);
Console.WriteLine();

if (array.GetLength(0) == array2.GetLength(1))
{
    PrintArray(productArr(array, array2));
}
else
{
    Console.WriteLine("Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");
}
