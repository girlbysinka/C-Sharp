﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
Console.Clear();

int userNumber = new int();
Console.WriteLine("Введите число:");
userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = -userNumber; i<=userNumber; i++)
{
    Console.Write(" ");
    Console.Write(i);
}