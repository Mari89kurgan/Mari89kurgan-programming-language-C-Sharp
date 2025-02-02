﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = number % 10 + sum;
        number = number / 10;
    }
    return sum;  
}

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetSum(x)}");