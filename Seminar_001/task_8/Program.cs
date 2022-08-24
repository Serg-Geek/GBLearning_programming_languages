//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Введите число: ");
int num =  int.Parse(Console.ReadLine());
if (num<=1) Console.WriteLine ("Вы ввели неправильное число(должно быть больше 1)");
int current = 1;
while (current <= num)
{
    if (current % 2 == 1)
        {
             current++;
        }
    else
        {
            Console.Write($"{current} ,");
            current++;
        }
}