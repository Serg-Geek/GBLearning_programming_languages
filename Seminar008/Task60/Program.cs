// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool IsInsideArray(int[,,] arrayCube, int num)
{
    foreach (int item in arrayCube)
    {
        if (item == num)
        {
            return true;
        }
    }
    return false;
}
int[,,] GetCube(int m, int n, int d)
{
    int[,,] result = new int[m, n, d];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < d; k++)
            {
                int num = new Random().Next(10, 100);
                while (IsInsideArray(result, num))
                {
                    num = new Random().Next(10, 100);
                }
                result[i, j, k] = num;
            }
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
void PrintArrayCube(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        
    }
}
int x = 0;
int y = 0;
int z = 0;
do
{
    Console.WriteLine("Введите размер х: ");
    x = Check();
    Console.WriteLine("Введите размер у");
    y = Check();
    Console.WriteLine("Введите размер z");
    z = Check();
} while (x * y * z > 90);
int[,,] ArrayCube = GetCube(x, y, z);
PrintArrayCube(ArrayCube);