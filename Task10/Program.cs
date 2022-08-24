/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1  */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a  = (num / 10) % 10;
if( num >99 & num < 1000)
{
    Console.WriteLine($"{num} -> {a}");
}
else
{
    Console.WriteLine($"{num} - Вы ввели не трёхзначное число");
}
