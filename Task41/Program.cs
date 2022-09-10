/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3    */

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        res[i] = int.Parse(Console.ReadLine());
    }
    return res;
}

int PositiveNums (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите число М: ");
int m = int.Parse(Console.ReadLine());
int[] newArray = GetArray(m);
Console.WriteLine($"Пользователь ввел числа:[{String.Join(", ", newArray)}]");
Console.WriteLine($"Положительных чисел: {PositiveNums(newArray)}");
