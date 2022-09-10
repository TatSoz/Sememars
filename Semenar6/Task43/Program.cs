/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
x = (b2-b1)/(k1-k2)   k1  b1    Вводим коэф. в виде массива 2х2
                      k2  b2
*/
double[,] GetArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }    
}

double[] PointCross (double[,] array)
{
    double[] PointCross = new double[2];
    PointCross[0] = (array[1,1] - array[0,1]) / (array[0,0] - array[1,0]);
    PointCross[1] = PointCross[0] * array[0,0] + array[0,1];
    return PointCross;
}

void OutputResponse(double[,] array, double[] PointCross)
{
  if (array[0,0] == array[1,0])
  {
    Console.WriteLine($"Прямые параллельны");
  }
  else 
  {
    Console.WriteLine($"Координаты точки пересечения прямых: ({PointCross[0]}, {PointCross[1]})");
  }
}


Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите коэфициенты к1, b1, k2, b2 ");
double[,] newArray = GetArray(n, m);
PrintArray(newArray);
double[] pointCoordinates = PointCross (newArray);
OutputResponse(newArray, pointCoordinates);
