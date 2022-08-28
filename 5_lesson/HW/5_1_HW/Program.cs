//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int EvenNumber(int[] arr)
{
    int N = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2==0)
        {
            N += 1;
        }
    }
    return N;
}

int[] arr_1 = MassNums(4);
Print(arr_1);
Console.WriteLine(EvenNumber(arr_1));
