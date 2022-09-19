/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9          */

int AckermannFun(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermannFun(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFun(m - 1, AckermannFun(m, n - 1));
    }
    else return n + 1;
}

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberM}, {numberN} -> {AckermannFun(numberM, numberN)}");
Console.WriteLine();
