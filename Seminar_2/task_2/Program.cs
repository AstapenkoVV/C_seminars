// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int WorkWithUser (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void MoreThirdDigit (int digit)
{
    while (digit > 999)
    {
        digit = (digit / 10);
    }
    Console.WriteLine("Третья цифра: " + digit % 10);
}
void ThirdDigit (int digit)
{
    if (digit > 99)
    {
        digit = digit % 10;
        Console.WriteLine("Третья цифра: " + digit);
    }
        else Console.WriteLine("Третьей цифры нет!!!");
}

int num = WorkWithUser("Введите число: ");
if (num > 999) MoreThirdDigit(num);
else ThirdDigit(num);