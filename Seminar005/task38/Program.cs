//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// Фунция заполнения массива
double[] CreateArray(int number, int minValue, int maxValue)
{
    int num = new Random().Next(minValue, maxValue);
    int width = maxValue-minValue;
    double[] array = new double [number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.NextDouble()*width+minValue;// +1??
    }
    return array;
}

// Функция получение строки и проверка на число int 32
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

void PrintArray(double[] array)// выводит массив
{
    int count = array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if(max<array[i])
        {
            max = array[i];
        }  
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if(min>array[i])
        {
            min = array[i];
        }  
    }
    return min;
}


Console.WriteLine("Введите длину массива: ");
int number = Check();

Console.WriteLine("Введите минимум диапазона массива: ");
int minValue = Check();

Console.WriteLine("Введите максимум диапазона массива: ");
int maxValue = Check();

double[] arr = CreateArray(number, minValue, maxValue);
PrintArray(arr);
Console.WriteLine();
double maxArray= FindMax(arr);
Console.WriteLine($"max= {maxArray}");
double minArray= FindMin(arr);
Console.WriteLine($"min= {minArray}");

Console.WriteLine($"разница между максимальным и минимальным элементов массива = {maxArray-minArray}.");
