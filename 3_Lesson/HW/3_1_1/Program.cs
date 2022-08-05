Console.Write("Enter the 5-digit number: ");
int a = int.Parse(Console.ReadLine());

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";

    while (i < size / 2)
    {
        if (num[i] != num[size - 1])
        {
            flag = "no";
            break;
        }
        i += 1;
    }
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome(a);
Console.WriteLine();