// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

if (9999 < n && n < 100000)
{
    int num1 = n / 1000;
    int num2 = n % 100;
    int rev_num2 = num2 / 10 + num2 % 10 * 10;

    if (num1 == rev_num2)
    {
        Console.WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {n} НЕ является палиндромом"); 
    }
}
else
{
    Console.WriteLine("Число должно быть пятизначным!");
}
