//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("input N");
int num = int.Parse(Console.ReadLine());
for (int i=1; i<=num;i++)// for - оператор цикла
{
    Console.Write($"{i*i*i}, ");
}