// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12


int Check()
{
    int number;
    while (true)
    {
        Console.WriteLine($"Ввудиту размук массива: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
            Console.WriteLine();
        }
    }
}

int FindSumNum(int num)// функция находит сумму цифз в числе

{
    int sum = 0;

    while(num>0)
    {
        sum = sum + num %10;
        num=num/10;   
    }
    return sum;
}

Console.WriteLine();
int number = Check();


Console.WriteLine($"Сумма цифр в числе {number} = {FindSumNum(number)}");