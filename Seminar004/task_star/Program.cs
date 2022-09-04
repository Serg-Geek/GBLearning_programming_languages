// Задача “со звездочкой”: Напишите функцию, которая принимает
// одно число - высоту елочки и рисует ее в консоли звездочками.

// Функция получение строки и проверка на число.
//* * 
int Check()
{
    int number;
    while (true)
    {
        Console.WriteLine($"введите число: ");
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

// функция для елочки

void PrintElka(int level )
{

            for (int i = 0, z = 1; i < level; i++, z+=2)
            {
                Console.Write(new string(' ',level--));
                Console.Write(new string('*',z));
                Console.WriteLine();
            }
 }



 Console.WriteLine("Введите высоту елки: ");
int Lev = Check();

PrintElka(Lev);
