/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет     */

Console.WriteLine("Введите число: ");
int day = int.Parse(Console.ReadLine());

if ( 0 < day && day <8)
{
    if (day > 5)
    {
        Console.WriteLine($"{day} -> да");
    }
    else 
    {
        Console.WriteLine($"{day} -> нет");
    }
}
else
{
    Console.WriteLine("Нет такого дня недели");
}
