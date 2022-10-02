// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void SelectionSort(int[] array)// сортирует
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j; // ищет мин элемент
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
void SortLines(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] arrayLine = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayLine[j] = array[i,j];
        }

        SelectionSort(arrayLine);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = arrayLine[j];
        }
    }
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
Console.WriteLine();
SortLines(matrix);
PrintArray(matrix);
