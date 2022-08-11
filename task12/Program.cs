// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
Console.Clear();
double number = PrintUserNumber();
int number1 = 7;
int number2 = 23;
CheckMultiplicityUserNumberTwoNumbers();

int PrintUserNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
    }

void CheckMultiplicityUserNumberTwoNumbers()
    {
    double remainder1 = number % number1;
    double remainder2 = number % number2;
    if(remainder1 == 0 & remainder2 == 0) 
    {
        Console.WriteLine($"Введенное число кратно числу {number1} и числу {number2}");
    }
    else
    {
        Console.WriteLine($"Введенное число НЕкратно одному из чисел: числу {number1}, числу {number2}");
    }
    return;
    }