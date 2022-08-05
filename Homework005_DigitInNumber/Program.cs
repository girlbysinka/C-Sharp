// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8
Console.Clear();

int userNumber = new int();
Console.WriteLine("Введите трёхзначное число: ");
userNumber = Convert.ToInt32(Console.ReadLine());

int digit = userNumber%10;

Console.Write($"Последняя цифра в числе = {digit}");