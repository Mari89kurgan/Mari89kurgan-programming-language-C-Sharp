﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetExponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;   
}

Console.Write("Введите число A: ");
int aNumber = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int bNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetExponentiation(aNumber, bNumber)}");
