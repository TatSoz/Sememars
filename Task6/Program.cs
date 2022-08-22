/*  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка )
4 -> да
-3 -> нет
7 - > нет  */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = num % 2;
if( result == 0)
{
    Console.WriteLine(" - чётное");
}
else 
    Console.WriteLine(" - нечётное");
