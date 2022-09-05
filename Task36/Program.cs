/*  Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0        */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void OddSum(int[] array)
{
    int oddSum = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            oddSum += array[i];
        }
    }
    Console.WriteLine($"{oddSum}");
}  

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int startRange = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int endRange = int.Parse(Console.ReadLine());

int[] myArray = GetArray(N, startRange, endRange);
Console.WriteLine(String.Join(", ", myArray));
OddSum(myArray);

