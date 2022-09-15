// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
void FindElem(int[,] array, int numEl)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numEl)
            {
                Console.WriteLine($"позиция элемента с значением {numEl}-[{i}, {j}]");
                return;
            }
        }
    }
    Console.WriteLine($"Такого числа в массиве нет");
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
Console.WriteLine("Введите число для проверки наличия в массиве: ");
int elem = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("input min: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("input max: ");
int maxValue = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] myarray = GetArray2(m, n, minValue, maxValue);
PrintArray(myarray);
Console.WriteLine();
FindElem(myarray, elem);
