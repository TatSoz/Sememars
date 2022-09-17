/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2                Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
5 9 2 3
8 4 2 4
5 2 6 7                  */

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

void SumElementsRows(int[,] array)
{
    int index = 0, minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов: {index + 1} ");
}


Console.WriteLine("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите началое значение диапазона: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное значение диапазона: ");
int end = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, start, end);
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
SumElementsRows(myArray);
