/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
Например, задан массив:
1 4 7 2                 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
5 9 2 3
8 4 2 4       */


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
            Console.Write($"{array[i, j]}\t ");
        }
    Console.WriteLine();
    }
}

void AverageColumnsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {   
        double sum = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
    double average = Math.Round(sum/array.GetLength(0),2);
    Console.WriteLine($"среднее арифметическое столбца № {i+1} = {average}");
    }

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
PrintArray(myArray);
AverageColumnsArray(myArray);
