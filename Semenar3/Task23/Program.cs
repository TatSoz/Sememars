/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125                 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int num1 = 1;
while (num1 <= num)
{
    Console.Write($"{num1*num1*num1}, ");
    num1++;
}
Console.WriteLine();  

/*for (int num1 = 1; num1 <= num; num1++)
{
    Console.Write($"{num1*num1*num1}, ");
}
Console.WriteLine();  */
