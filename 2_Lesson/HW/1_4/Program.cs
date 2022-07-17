void Weekend(int a)
{
    string text = "no";

    if (a == 7 || a == 6) text = "yes";
    Console.WriteLine($"{a} > {text}");
}

Weekend(6);
Weekend(7);
Weekend(1);
// ....