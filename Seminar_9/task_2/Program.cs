/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SummNumbers(int m, int n)
{
    if (m > n) return 0;
    else return m + SummNumbers(m + 1, n);
}

int m = WorkWithUser("Введите наименьшее число M: ");
int n = WorkWithUser("Введите наибольшее число N: ");
Console.WriteLine(SummNumbers(m, n));