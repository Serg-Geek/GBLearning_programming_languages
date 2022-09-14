//Задача 50: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

//17 -> такого числа в массиве нет


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

void Elem(int[,] Array, int row, int col)
{

    if (row > Array.GetLength(0) || col > Array.GetLength(1) || row <0 || col < 0)
    {
        Console.WriteLine("такого числа в массиве нет");

    }
    else
    {
       int elem = Array[row, col]; 
       Console.WriteLine(elem);
    }
}
void PrintArray(int[,] array)
{
   
    for(int i =0; i<array.GetLength(0); i++ )
{
    for( int j=0; j<array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}


Console.WriteLine("input m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("input n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("input min: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("input max: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] myarray = GetArray2(m, n, minValue, maxValue);
PrintArray(myarray);
Console.WriteLine("input x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("input y: ");
int y = int.Parse(Console.ReadLine());
Elem(myarray, x,y);
