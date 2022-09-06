// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

// Фунция заполнения массива
int[] CreateArray(int number, int minValue, int maxValue)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

//функция вывода массива
void Write(int []arr)
{
    for (int i= 0; i<arr.Length; i++)
    {
        Console.Write(String.Join(", ", arr[i]));
        Console.Write(" ");
    }
    Console.WriteLine();
}

// Функция получение строки и проверка на число.

int Check()
{
    int number;
    while (true)
    {
        Console.WriteLine();
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
// фунция складывает нечетные элементы массива
int Oddsum(int[] array)
{
    
    int sum = 0;
    for (int i =0; i<array.Length; i++)
    { 
        int odd = array[i] %2;
        if (odd != 0)
        {
            sum=sum+array[i];
        }
    }
    return sum;     
}

Console.WriteLine("Введите длину массива: ");
int lenght = Check();
Console.WriteLine("Введите нижнее значение диапазона массива: ");
int minValue = Check();
Console.WriteLine("Введите верхнее значение диапазона массива");
int maxValue = Check();


int[] oddsumarray = CreateArray(lenght, minValue, maxValue);

Write(oddsumarray);


Console.WriteLine($"Cумма нечетных элементов:  {Oddsum(oddsumarray)}");