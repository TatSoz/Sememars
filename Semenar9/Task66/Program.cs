/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30           */

int SumNumber(int m, int n)
{
    if (m == n) return m;
    return n + SumNumber(m, n - 1);
}

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberM}, {numberN} -> {SumNumber(numberM, numberN)}");
Console.WriteLine();

