//Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

//5, 0, 20 -> [1, 2, 5, 7, 19]
//3, 1, 35 -> [6, 1, 33]

// Фунция заполнения массива
int[] CreateArray(int number, int min, int max)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(min, max);
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
        Console.WriteLine($"число: ");
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

Console.WriteLine("Введите длину массива: ");
int lenght = Check();

Console.WriteLine("Введите минимум диапазона массива: ");
int min = Check();

Console.WriteLine("Введите максимум диапазона массива: ");
int max = Check();

Write(CreateArray(lenght, min, max));


//Console.WriteLine(String.Join(", ", myArray));