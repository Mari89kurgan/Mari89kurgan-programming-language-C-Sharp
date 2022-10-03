// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumberSum(int m, int n, int result = 0)
{
    if (m < n + 1)
    {
        result += m + NumberSum(++m, n, result);
    }
    return result;
}

Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

Console.Write($"Cумму натуральных элементов в промежутке от {m} до {n}: {NumberSum(m, n)}");
