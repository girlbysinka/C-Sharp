// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
Console.Clear();

int a = new Random().Next(1,10);
Console.WriteLine(a);

int count = -a;

while (count <= a)
{
    Console.Write(" ");
    Console.Write(count);
    count++;
}