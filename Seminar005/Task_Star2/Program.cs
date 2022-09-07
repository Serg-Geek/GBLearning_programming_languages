// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
//[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
//[1,2,2,3,2] -> [3, 2, 2, 2, 1]

// Фунция заполнения массива
int[] CreateArray(int number, int minValue, int maxValue)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next( minValue, maxValue);
    }
    return array;
}

// Функция получение строки и проверка на число.

int Check()
{
    int number;
    while (true)
    {
        Console.WriteLine(" ");
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

int[] SelectionSort(int[] array)// сортирует
{
    for (int i =0; i< array.Length-1; i++)
    {
        int minPosition=i;

        for (int j = i +1; j< array.Length; j++ )
        {
            if (array[j] > array[minPosition]) minPosition=j; // ищет мин элемент
        }

        int temp = array[i];            
        array[i] = array [minPosition];
        array[minPosition] = temp;
    }
return array;
}

Console.WriteLine("Введите длину массива: ");
int number = Check();

Console.WriteLine("Введите минимум диапазона массива: ");
int minValue = Check();

Console.WriteLine("Введите максимум диапазона массива: ");
int maxValue = Check();

int[] arr = CreateArray(number, minValue, maxValue);
Write(arr);
Write(SelectionSort(arr));
