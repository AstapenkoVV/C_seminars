/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string ShowNumbers(int a, int number)
{
    if (a <= number) return ShowNumbers(a + 1, number) + $"{a} ";
    else return String.Empty;
}
int a = 1;
int n = WorkWithUser("Введите число N: ");
Console.WriteLine($"[ {ShowNumbers(a, n)}]");