
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double[] CrossPoint(double k1, double b1, double k2, double b2)// возвращает массив [o] наличие пересечения
{
    double[] point = new double[3];
    if (k1 == k2)
    {
        point[0] = 0;
        return point;
    }
    point[0] = 1;
    point[1] = (b2 - b1) / (k1 - k2);
    point[2] = k1 * point[1] + b1;
    return point;
}
void Write(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(String.Join(", ", arr[i]));
        Console.Write(" ");
    }
    Console.WriteLine();
}
// Функция получение строки и проверка на число double
double CheckDouble()
{
    double number;
    while (true)
    {
        Console.WriteLine($": ");
        string str = Console.ReadLine();
        try
        {
            number = Convert.ToDouble(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка!!!!! Неверное число. Попробуйте еще раз только цифры.");
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Введите коэффицент к1");
double k1 = CheckDouble();
Console.WriteLine("Введите коэффицент b1");
double b1 = CheckDouble();
Console.WriteLine("Введите коэффицент к2");
double k2 = CheckDouble();
Console.WriteLine("Введите коэффицент b2");
double b2 = CheckDouble();
double[] pointarr = CrossPoint(k1, b1, k2, b2);
if (pointarr[0]==0)
{
Console.WriteLine("Прямые не пересекаются или линии одинаковы");
}
else
{
Console.WriteLine($"Координаты точки пересечения прямых: {pointarr[1]},{pointarr[2]}");
}
