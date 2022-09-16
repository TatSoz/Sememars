/* Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.   */

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

void OrderDescendingArrayRows(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
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
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
Console.WriteLine("Отсортированный массив:");
OrderDescendingArrayRows(myArray);
PrintArray(myArray);
