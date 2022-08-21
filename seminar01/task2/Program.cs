// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (a > b) 
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
  
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");