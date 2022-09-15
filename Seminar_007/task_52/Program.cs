// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray2(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// Функция получение строки и проверка на число.
int Check2()
{
    int number;
    while (true)
    {
        Console.WriteLine($"Введите число: ");
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
// Функция получение строки и проверка на число > 1.
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
            if (number >= 2)
            {
                return number;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
            Console.WriteLine();
        }
    }
}
double[] SumCol(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[i] += array[j, i];
        }
        sum[i] = sum[i] / array.GetLength(0);
    }
    return sum;
}

void PrintArray(int[,] array)
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

Console.WriteLine("input m: ");
int m = Check();
Console.WriteLine("input n: ");
int n = Check();
Console.WriteLine("input min: ");
int minValue = Check2();
Console.WriteLine("input max: ");
int maxValue = Check2();
Console.WriteLine();
int[,] myarray = GetArray2(m, n, minValue, maxValue);
PrintArray(myarray);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
double[] middlecol = SumCol(myarray);
Console.WriteLine(string.Join("\t", middlecol));