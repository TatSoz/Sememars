/*  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18        */

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
    Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    //if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < multiMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiMatrix.GetLength(1); j++)
            {
                multiMatrix[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    multiMatrix[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    //else Console.WriteLine("Умножение невозможно!");
    return multiMatrix;
}                       


Console.WriteLine("Введите количество строк первой матрицы row1: ");
int row1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы colm1: ");
int colm1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы row2: ");
int row2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы colm2: ");
int colm2 = int.Parse(Console.ReadLine());

int[,] firstMatrix = GetMatrix(row1, colm1);
Console.WriteLine("Первая матрица: ");
Print(firstMatrix);
int[,] secondMatrix = GetMatrix(row2, colm2);
Console.WriteLine("Вторая матрица: ");
Print(secondMatrix);

if (colm1 == row2)
{
    int[,] array = MultiplicationMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Результирующая матрица: ");
    Print(array);
}
else Console.WriteLine("Умножение невозможно!");


