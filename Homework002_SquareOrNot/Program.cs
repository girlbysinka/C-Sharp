// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
int a = new Random().Next(-3,25); // 25, 2, 9, -3
Console.Write ("a = ");
Console.WriteLine (a);

int b = new Random().Next(-3,10); // 5, 10, -3, 9
Console.Write ("b = ");
Console.WriteLine (b);

int square = b * b;

if(a == square)
{
Console.Write ("Yes, square = ");
Console.WriteLine (a);
}
else
{
Console.Write ("No, square = ");
Console.Write (square);
Console.Write (", a = ");
Console.WriteLine (a);
}