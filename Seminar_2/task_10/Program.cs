//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8 
//918 -> 1
Console.WriteLine("Виедите трехзначное число: ");
int num =  int.Parse(Console.ReadLine());
if (num >999 && num <100) Console.WriteLine(" число: ");
else
{
    //int a2 = num % 100;
    //int result = a2/10;
    int result = (num%100)/10;
    Console.WriteLine($"{result}");
}