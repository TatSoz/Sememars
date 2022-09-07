/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива*/

double[] GetArray(int size)
{
    double[] array = new double[size];
  
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}

double NumMin(double[] array)
{
    double numMin = array[0];
    for (int i =0; i < array.Length; i++)
    {
        if (numMin > array[i])
        numMin = array[i];
    }
    return numMin;
}    
double NumMax(double[] array)
{
    double numMax = array[0];
    for (int i =0; i < array.Length; i++)
    {
        if (numMax < array[i])
        numMax = array[i];
    }
    return numMax;
   
}

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
double[] myArray = GetArray(N);
Console.WriteLine(String.Join(", ", myArray));
Console.WriteLine($"Максимальное значение: = {NumMax(myArray)}");
Console.WriteLine($"Минимальное значение: = {NumMin(myArray)}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: = {NumMax(myArray) - NumMin(myArray)}");
