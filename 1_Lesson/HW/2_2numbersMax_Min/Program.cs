Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());
int max;
int min;

if (a < b)
{
    Console.Write("max=");
    Console.WriteLine(max = b);
    Console.Write("min=");
    Console.WriteLine(min = a);
}
else
{
    Console.Write("max=");
    Console.WriteLine(max = a);
     Console.Write("min=");
    Console.WriteLine(min = b);
}