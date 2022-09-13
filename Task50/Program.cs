/* Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3               17 -> такого числа в массиве нет;
8 4 2 4           */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    Console.WriteLine();
    }
}

void SearchNumber(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num)
            {
                Console.WriteLine($"[{i}, {j}]");
                return;
            }
        }
    }
    Console.WriteLine($"{num} -> такого числа в массиве нет");
}


Console.WriteLine("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите началое значение диапазона: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное значение диапазона: ");
int end = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());


int[,] myArray = GetArray(m, n, start, end);
PrintArray(myArray);
SearchNumber(myArray, number);
