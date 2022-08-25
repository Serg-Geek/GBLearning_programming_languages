// Задача 13: Напишите программу, которая выводит третью цифру 
//(справа налево) заданного числа или сообщает, что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Виедите число 1: ");
int num =  int.Parse(Console.ReadLine());
if (num<100)  Console.WriteLine("третьей цифры нет");


//int a2 = num % 100;
//int result = a2/10;
int result = (num%1000)/100;
Console.WriteLine($"{result}");    