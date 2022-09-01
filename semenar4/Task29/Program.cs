/* Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) 
и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19] 
3, 1, 35 -> [6, 1, 33]      */


int[] GetArray(int numA, int numB, int numN)
{
    int[] arr = new int[numN];
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(numA, numB);
    }
    return arr;
}

Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", GetArray(numberA, numberB, numberN)));
