void Print2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Fill2xArray(int row, int column)
{
    int[,] arr = new int[row,column];
    
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            arr[i,j]=i+j;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return(arr);
}

Console.Write("Enter number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] arr1 = Fill2xArray(row,column);
Print2xArray(arr1);