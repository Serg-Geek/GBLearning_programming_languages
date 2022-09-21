// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Фунция заполнения массива
int[] CreateArray(int minValue, int maxValue)
{
    int size = maxValue - minValue - 1;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = minValue + i + 1;
    }
    return array;
}
int NaturalisSum(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            res += array[i];
        }
    }
    return res;
}

// Функция получение строки и проверка на число.
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
void Write(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(String.Join(", ", arr[i]));
        Console.Write(" ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите минимум: ");
int min = Check();
Console.WriteLine("Введите Max: ");
int max = Check();
int[] myarray = CreateArray(min, max);
Write(myarray);
int result = NaturalisSum(myarray);
Console.WriteLine();
Console.WriteLine($"Cумма  натуральных элементов в промежутке от {min}  до {max} = {result}");
