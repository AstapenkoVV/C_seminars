// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Work(int number, int exponent)
{
    int temp = 1;
    for (int i = 0; i < exponent; i++)
    {
        temp *= number;
    }
    return temp;
}

int a = WorkWithUser("Введите число А: ");
int b = WorkWithUser("Введите степень В: ");
if (b > 0) Console.WriteLine($"Число {a} в сепени {b} равно {Work(a, b)}");
else Console.WriteLine("Степень не натуральная!");