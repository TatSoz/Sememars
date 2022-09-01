/* Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12    */

int Sum(int number)
{
    int sum = 0;
    for (int i = 0; number >= 1; i++ )
    {
        sum+= number % 10;
        number = number/10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} -> {Sum(num)}");
