//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

// Функция получение строки и проверка на число.

int Check()
{
    int number;
    while (true)
    {
        Console.WriteLine($" : ");// введите число
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

// функция возведения в степень

int Pow(int num, int num2)
{
    int result = num;
    for(int i=0; i<num2-1; i++)
    {
         result = result *num;
    }
    return result;
}


Console.WriteLine("Введите число:");
int number = Check();

Console.WriteLine("Введите степень");
int pow = Check();

int res = Pow(number, pow);


Console.WriteLine($"{number}^{pow}={res}");
