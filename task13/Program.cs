// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет
Console.Clear();

double number1 = PrintFirstNumber();
double number2 = PrintSecondNumber();
Console.WriteLine();
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
    if(number1 == number2 * number2)
        {
        Console.Write ($"Число {number1} является квдратом числа {number2}");
        }

    else if (number2 == number1 * number1)
        {
        Console.Write ($"Число {number2} является квдратом числа {number1}");
        }
            
        else
        {
            Console.Write ("Введенные числа не являются квадратами друг друга");
        }

    return;
    }