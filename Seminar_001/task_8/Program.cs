Console.WriteLine("Введите число: ");
int num =  int.Parse(Console.ReadLine());
if (num<=1) Console.WriteLine ("Вы ввели неправильное число(должно быть больше 1)");
int current = 1;
while (current <= num)
{
    if (current % 2 == 1)
        {
             current++;
        }
    else
        {
            Console.Write($"{current} ,");
            current++;
        }
}