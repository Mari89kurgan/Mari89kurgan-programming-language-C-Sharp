// Задача 60. ...
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix(int row, int col, int dep)
{
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int number = new Random().Next(10, 100);

                while (checkAvailability(matrix, number))
                {
                    number = new Random().Next(10, 100);
                }
                matrix[i, j, k] = number;
            }
        }
    }
    return matrix;
}

bool checkAvailability(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}");
                Console.Write($"({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3D = CreateMatrix(2, 2, 2);
PrintMatrix(array3D);
