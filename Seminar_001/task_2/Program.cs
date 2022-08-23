Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
int max = a;
if (max > b)
{
   Console.WriteLine($"max ={max}");
}
else
{
    Console.WriteLine($"max ={b}");
}