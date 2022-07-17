void Number (int a)
{
    Console.Write($"{a} > ");
    if (a < 99)
    {
        Console.WriteLine("Нету третьей цифры");
        return;
    }
    
    while (a > 999) a = a / 10;
    Console.WriteLine(a % 10);
}

Console.Write("введите число = ");
Number(int.Parse(Console.ReadLine()));