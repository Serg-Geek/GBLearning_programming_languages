Console.WriteLine("Введите число а");

int a =  int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");

int c = int.Parse(Console.ReadLine());
int max=a;
if (max < b)   
{
    max= b;
}
if (max<c)
{
    max = c;
}    
Console.WriteLine($"max ={max}");
