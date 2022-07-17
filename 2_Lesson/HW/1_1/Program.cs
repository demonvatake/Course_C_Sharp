//Console.WriteLine("Write a number: ");

//int a = int.Parse(Console.ReadLine());

//Console.WriteLine((a / 10) % 10);
Console.Write("Write a number: ");

int a = int.Parse(Console.ReadLine());
int Num(int a)
{
    return a / 10 % 10;
}

Console.Write("вторая цифра этого числа > ");
Console.WriteLine(Num(a));