﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели: понедельник - 1, вторник -2, среда - 3, четверг-4, пятница - 5, суббота -6, воскресенье -7: ");
int num =  int.Parse(Console.ReadLine());
if (  num < 1 &&  num > 7 ) 
{
    Console.WriteLine("Вы ввели неправильное число");
}
if (num == 6 || num ==7)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}