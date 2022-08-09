void Quarters(int a)
{
    if (a == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (a == 2)
        Console.WriteLine("x < 0 && y > 0");
    else if (a == 3)
        Console.WriteLine("x < 0 && y < 0)");
    else if (a == 4)
        Console.WriteLine("x < 0 && y < 0)");
    else
        Console.WriteLine("error");
}

Console.Write("введите число = ");
Quarters(int.Parse(Console.ReadLine()));