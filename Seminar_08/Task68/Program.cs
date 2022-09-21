// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

// функция Аккермана
int AckermannMethod(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckermannMethod(n - 1, 1);
    else
        return AckermannMethod(n - 1, AckermannMethod(n, m - 1));
}
// Функция получение строки и проверка на число > 0.
int CheckNumberMoreZero()
{
    int number;
    while (true)
    {
        Console.WriteLine($"Введите число не менее 0: ");
        string str = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(str);
            while (number >= 0)
            {
                try
                {
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!!!!! Неверное число. необходимо >0.");
                    Console.WriteLine();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Введите число n для функции Аккермана: ");
int n = CheckNumberMoreZero();
Console.WriteLine("Введите число m для функции Аккермана: ");
int m = CheckNumberMoreZero();
int result = AckermannMethod(n, m);
Console.WriteLine();
Console.WriteLine($"A(n,m) = {result}");