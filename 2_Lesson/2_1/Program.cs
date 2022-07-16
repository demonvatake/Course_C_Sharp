Console.WriteLine("Write a number: ");

int num = int.Parse(Console.ReadLine());
int TakeNum(int num)
{
    return num % 10;
}

Console.Write("последняя цифра этого числа: ");
Console.WriteLine(TakeNum(num));
