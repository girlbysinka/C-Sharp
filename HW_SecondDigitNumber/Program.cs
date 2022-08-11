/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
int userNumber = PrintUserNumber();

if (userNumber > 100 & userNumber < 999)
    {
    int digit = (userNumber / 10) % 10;
    Console.Write($"Вторая цифра в введенном числе = {digit}");
    }

else
    {
        Console.Write("Введенное число не является трёхзначным.");
    }

int PrintUserNumber()
    {
        int userNumber = new int();
        Console.WriteLine("Введите трёхзначное число: ");
        userNumber = Convert.ToInt32(Console.ReadLine());
      
    return userNumber;
    }