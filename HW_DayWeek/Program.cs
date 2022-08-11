/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();

int day = PrintUserNumber();
CheckedDayOfWeek ();

void CheckedDayOfWeek ()
    {
    if (day<=0 || day>7)
        {
            Console.WriteLine("Неправильное число");
        }

    if (day==1) 
        {
            Console.WriteLine("Понедельник");
        }

    else if (day==2)
        {
            Console.WriteLine("Вторник");
        }
    else if (day==2)
        {
            Console.WriteLine("Вторник");
        }
    else if (day==3)
        {
            Console.WriteLine("Среда");
        }
    else if (day==4)
        {
            Console.WriteLine("Четверг");
        }
    else if (day==5)
        {
            Console.WriteLine("Пятница");
        }
    else if (day==6)  
        {
            Console.WriteLine("Суббота");
        }
    else if (day==7)
        {
            Console.WriteLine("Воскресенье");
        }
    return;
    }


int PrintUserNumber()
    {
        int userNumber = new int();
        Console.WriteLine("Введите число: ");
        userNumber = Convert.ToInt32(Console.ReadLine());
      
    return userNumber;
    }