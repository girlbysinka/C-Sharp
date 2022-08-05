// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
Console.Clear();
int userNumber1 = new int();
Console.WriteLine("Введите число:");
userNumber1 = Convert.ToInt32(Console.ReadLine());

int userNumber2 = new int();
Console.WriteLine("Введите возможный квадрат числа:");
userNumber2 = Convert.ToInt32(Console.ReadLine());

if(userNumber1 == userNumber2 * userNumber2)
{
Console.Write ("True");
}

else
{
Console.Write ("False");
}