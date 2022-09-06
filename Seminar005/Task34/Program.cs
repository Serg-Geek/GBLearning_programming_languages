// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// Фунция заполнения массива
int[] CreateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100, 999);
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
        Console.WriteLine($"Введите размер массива: ");
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

int EvenCount(int[] array)
{
    int res = 0;
    for (int i =0; i<array.Length; i++)
    { 
        int even = array[i] %2;
        if (even == 0)
        {
            res++;
        }
    }
    return res;     
}

int lenght = Check();

int[] evencountarray = CreateArray(lenght);

Write(evencountarray);

//EvenSum(evensumarray);

Console.WriteLine($"Количество четных элементов:  {EvenCount(evencountarray)}");