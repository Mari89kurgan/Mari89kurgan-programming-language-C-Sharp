// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, 
// что третьей цифры нет.

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

int num = a % 1000 / 100;

if(num == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(Math.Abs(num));    
}
