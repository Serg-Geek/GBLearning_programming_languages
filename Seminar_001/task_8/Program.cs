Console.WriteLine("Введите число: ");

int num =  int.Parse(Console.ReadLine());

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

