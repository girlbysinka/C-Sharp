// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
Console.Clear();
int GetRandomNumberInRange(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber, maxNumber + 1);
    return result;
}

void DeleteSecondDigitFromNumber(int number)
{
    int digit1 = number / 100;
    int digit3 = number % 10;
    Console.WriteLine($"Новое число без второй цифры {digit1}{digit3}");
    return;
}
int randomNumber = GetRandomNumberInRange(100,999);
Console.WriteLine($"Случайное трёхзначное число {randomNumber}");
DeleteSecondDigitFromNumber(randomNumber);