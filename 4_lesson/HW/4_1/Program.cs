// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
Console.Write("Enter the number: ");
int A = int.Parse(Console.ReadLine());

Console.Write("NumberToThePower: ");
int B = int.Parse(Console.ReadLine());

double NumberToThePower(int A, int B)
{
    double pow = Math.Pow(A,B);
    return pow;
}
Console.WriteLine(NumberToThePower(3,5));
Console.WriteLine(NumberToThePower(A,B));
