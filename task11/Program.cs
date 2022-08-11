/* Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 16, 4 -> */
Console.Clear();
double number1 = PrintFirstNumber();
double number2 = PrintSecondNumber();
CheckMultiplicityNumberOneNumberTwo();


int PrintFirstNumber()
    {
    int userNumber1 = new int();
    Console.WriteLine("Введите первое число:");
    userNumber1 = Convert.ToInt32(Console.ReadLine());
    return userNumber1;
    }

int PrintSecondNumber()
    {
    int userNumber2 = new int();
    Console.WriteLine("Введите второе число:");
    userNumber2 = Convert.ToInt32(Console.ReadLine());
    return userNumber2;
    }

void CheckMultiplicityNumberOneNumberTwo()
    {
    double remainder = number1 % number2;
    if(remainder == 0) 
    {
        Console.WriteLine($"Число {number2} кратно числу {number1}");
    }
    else
    {
        Console.WriteLine($"Число {number2} НЕкратно числу {number1}. Остаток от деления равен {remainder}");
    }
    }