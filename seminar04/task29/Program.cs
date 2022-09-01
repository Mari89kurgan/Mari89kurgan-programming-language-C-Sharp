// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) 
// и выводит их на экран.

// 5, 0, 20 -> [1, 2, 5, 7, 19] 
// 3, 1, 35 -> [6, 1, 33]

void InitArray(int start, int finish, int count)
{
    int [] arr = new int[count];
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(start, finish);
    }
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Количество элементов в массиве: ");
int myCount = int.Parse(Console.ReadLine());
Console.Write("Введите случайное число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите случайное число B: ");
int b = int.Parse(Console.ReadLine());

InitArray(a, b, myCount);