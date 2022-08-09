﻿// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причем X не равно 0 или Y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

Quarters(0, 9);
Quarters(2, 2);
Quarters(-3, 9);
Quarters(-4, -9);
Quarters(4, -9);
