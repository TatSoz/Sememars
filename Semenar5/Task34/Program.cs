/*  Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.       */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void EvenNumber(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        evenNum++;
    }
    Console.WriteLine($"{evenNum}");
}

int[] myArray = GetArray(20, 100, 999);
Console.WriteLine(String.Join(", ", myArray));
EvenNumber(myArray);
