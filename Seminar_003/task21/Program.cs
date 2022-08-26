// Задача 21: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("input x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("input y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("input z1: ");
double  z = double.Parse(Console.ReadLine());

Console.WriteLine("input x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("input y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("input z2: ");
double z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2))+((z1-z2)*(z1-z2)));
Console.WriteLine($"{result:f2}");// "{result:f2}" два знака после запятой
