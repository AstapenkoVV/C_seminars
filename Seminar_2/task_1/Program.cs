// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

int WorkWithUser (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FindNumber(int num)
{
    if (num > 99 && num <1000)
    {
        int n = (num / 10) % 10;
        Console.WriteLine("Втарая цифра числа: " + n);
    }
    else Console.WriteLine("Это не 3х значное число.!!!");
}

int x = WorkWithUser("Введите 3х значное число: ");
FindNumber(x);