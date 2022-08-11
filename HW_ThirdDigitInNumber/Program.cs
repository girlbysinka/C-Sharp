/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();

int userNumber = PrintUserNumber();
int quotient = userNumber;
CheckThirdDigitInNumber ();

void CheckThirdDigitInNumber ()
    {
        int count = 0;
    
        while (quotient >= 1000)
        {
            quotient = quotient / 10;
            Console.WriteLine(quotient);
            count++;
        }
 
        if (quotient > 99 & quotient < 1000)
        {
            int remainder = quotient % 10;
            Console.Write($"Третья цифра в введенном числе = {remainder}");
        }
        else
            {
                Console.Write("В введенном числе третьей цифры нет.");
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