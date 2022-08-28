/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53    */

Console.Write("Bведите абсциcсу первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Bведите ординату первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Bведите аппликату первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Bведите абсциcсу второй точки: ");
int x2= int.Parse(Console.ReadLine());
Console.Write("Bведите ординату второй точки: ");
int y2= int.Parse(Console.ReadLine());
Console.Write("Bведите аппликату второй точки: ");
int z2 = int.Parse(Console.ReadLine());


double d = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.WriteLine($"d = {d:f2}");




