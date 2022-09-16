/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9          */

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double matrix = Math.Round(array[i, j], 2);
            Console.Write($"{matrix}\t");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n:");
int n = int.Parse(Console.ReadLine());

double[,] myArray = GetArray(m, n);
PrintArray(myArray);
