
// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Функция получение строки и проверка на число.

int Check()
{
    int number;
    while (true)
    {
        Console.WriteLine($"Введите число не менее 2: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            while (number >= 2)
            {
                try
                {
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!!!!! Неверное число. необходимо >1.");
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
// Функция получение строки и проверка на число double
double CheckDoudle()
{
    double number;
    while (true)
    {
        Console.WriteLine($": ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToDouble(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
            Console.WriteLine();
        }
    }
}

// Фунция заполнения массива
double[,] GetArrayDouble(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    double width = maxValue - minValue;
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.NextDouble() * width + minValue;
        }
    }
    return result;
}

Console.WriteLine("input row: ");
int m = Check();
Console.WriteLine("input col: ");
int n = Check();
Console.WriteLine("input min: ");
double minValue = CheckDoudle();
Console.WriteLine("input max: ");
double maxValue = CheckDoudle();
Console.WriteLine();
double[,] myarray = GetArrayDouble(m, n, minValue, maxValue);
PrintArray(myarray);
