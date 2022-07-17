int a = new Random().Next(100,999);
int b = ((a / 10 / 10) % 10);
int c = (a % 10);

Console.WriteLine(a);
Console.Write(b);
Console.Write(c);
