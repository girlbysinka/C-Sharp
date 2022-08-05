/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> */
Console.Clear();

int userNumber = new int();
Console.WriteLine("Введите число:");
userNumber = Convert.ToInt32(Console.ReadLine());

int remainder = userNumber%2;

if(remainder == 0) Console.WriteLine("Чётное");
else Console.WriteLine("Нечётное");