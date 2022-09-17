/*  Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07    */



void GetArraySpiral(int[,] array)
{
    int value = 1;
    int curentRow = 0;
    int curentCol = 0;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
        while ((curentRow < rows-curentRow) && (curentCol < cols-curentCol))
        {
            for (int j = curentCol; j < cols-curentCol; j++)
            {
                array[curentRow,j] = value; 
                value ++;
            }
            for (int i = curentRow + 1; i < rows-curentRow; i++ )
            {
                array[i,cols-curentCol-1] = value;
                value++;
            }
            for (int j = cols-curentCol-2; j >= curentCol; j-- )
            {
                array[rows - curentRow-1,j] = value;
                value++;
            }
            for (int i = rows - curentRow-2; i > curentRow; i--)
            {
                array[i, curentCol] = value;
                value ++;
            }
             curentRow ++;
             curentCol ++;
        }   
}       

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк и столбцов массива n: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = new int[n, n];
GetArraySpiral(myArray);
Console.WriteLine("Массив: ");
PrintArray(myArray);
