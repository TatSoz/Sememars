/* Напишите программу, которая выводит третью цифру (справа налево) заданного 
числа или сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6   */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = num / 100;
int num2 = num1 % 10;

if(num > 99)
{
    if(num >= 1000)
    {
        Console.WriteLine($"{num} -> {num2}");
    }
    else 
    {
       Console.WriteLine($"{num} -> {num1}");
    }
}   
else
{
    Console.WriteLine("Третьей цифры нет");
}
