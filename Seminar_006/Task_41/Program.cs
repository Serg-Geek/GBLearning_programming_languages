// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


//Функция получение строки и проверка на число > 0.
int CheckNumberMoreZero()
{
    int number;
    while (true)
    {
        Console.WriteLine($"Введите число не менее 1: ");
        string str = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(str);
            if (number >= 1)
            {
                return number;
            }
            Console.WriteLine("Ошибка!!!!! Неверное число. необходимо >0.");
            Console.WriteLine();
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
            Console.WriteLine();
        }
    }
}
int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        int num = 0;
        while (true)
        {
            Console.WriteLine($"Введите число: ");
            string str = Console.ReadLine();
            try
            {
                num = Convert.ToInt32(str);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
                Console.WriteLine();
            }
        }
        array[i] = num;
    }
    return array;
}
//функция вывода массива
void Write(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(String.Join(", ", arr[i]));
        Console.Write(" ");
    }
    Console.WriteLine();
}
void CountPositivNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} чисел больше 0.");
}
Console.WriteLine("Введите сколько Вы хотите ввести чисел: ");
int countNum = CheckNumberMoreZero();
int[] myarray = GetArray(countNum);
Console.WriteLine();
Write(myarray);
Console.WriteLine();
CountPositivNum(myarray);