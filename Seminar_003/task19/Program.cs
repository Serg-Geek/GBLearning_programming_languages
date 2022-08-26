// Задача 19: Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
//14212 -> нет/
//23432 -> да
//12821 -> да
Console.WriteLine("Введите пятизначное  число: ");
int num =  int.Parse(Console.ReadLine());
if (num <10000 || num > 99999)
{
  Console.WriteLine(" Вы ввели не пятизначное  число.");
}
int num1 = num/10000;
int num2 = (num % 10000)/1000;
int num4= (num % 100)/10;
int num5= num% 10;

if (num1==num5 && num2 == num4)
{
    Console.WriteLine("ДА");  
}
else
{
    Console.WriteLine("HET");
}
