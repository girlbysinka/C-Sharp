﻿/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();

int userNumber1 = new int();
Console.WriteLine("Введите число 1:");
userNumber1 = Convert.ToInt32(Console.ReadLine());

int userNumber2 = new int();
Console.WriteLine("Введите число 2:");
userNumber2 = Convert.ToInt32(Console.ReadLine());

int userNumber3 = new int();
Console.WriteLine("Введите число 3:");
userNumber3 = Convert.ToInt32(Console.ReadLine());

int max = userNumber1;

if(userNumber2 > userNumber1) max = userNumber2;
if(userNumber3 > userNumber2) max = userNumber3;

Console.WriteLine($"Max = {max}");