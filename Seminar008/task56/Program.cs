// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Check()
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
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
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
int[] SumRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}
void Write(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} \t"); ;
        Console.Write(" ");
    }
    Console.WriteLine();
}
void FindMin(int[] array)
{
    int i = 0;
    int minPosition = i;
    for (i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // ищет мин элемент
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {minPosition + 1}");
}
Console.WriteLine("Введите кол-во строк");
int row = Check();
Console.WriteLine("Введите кол-во столбцов");
int col = Check();
Console.WriteLine("Введите minimum диапазона массива");
int minsize = Check();
Console.WriteLine("Введите мах диапазона массива");
int maxsize = Check();
Console.WriteLine();
int[,] matrix = GetMatrix(row, col, minsize, maxsize);
PrintArray(matrix);
Console.WriteLine();
int[] sum = SumRow(matrix);
Write(sum);
Console.WriteLine();
FindMin(sum);