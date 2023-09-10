// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int WorkWithUser (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void NumberWeek (int number)
{
    if (number == 1) Console.WriteLine("Этот день недели не является выходным!");
    else if (number == 2) Console.WriteLine("Этот день недели не является выходным!");
    else if (number == 3) Console.WriteLine("Этот день недели не является выходным!");
    else if (number == 4) Console.WriteLine("Этот день недели не является выходным!");
    else if (number == 5) Console.WriteLine("Этот день недели не является выходным!");
    else if (number == 6) Console.WriteLine("Этот день недели является выходным! УРА))))");
    else if (number == 7) Console.WriteLine("Этот день недели является выходным! УРА))))");
    else Console.WriteLine("Такого дня недели не существует!");
}

int num = WorkWithUser("Введите день недели: ");
NumberWeek(num);