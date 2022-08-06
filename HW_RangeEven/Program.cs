/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.Clear();

int userNumber = new int();
Console.WriteLine("Введите число:");
userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber<=1)
{
    Console.WriteLine("Неверное число (меньше 1). Введите новое число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i <= userNumber; i++)
{
if((i%2)==0) Console.Write($" " + i);
}   