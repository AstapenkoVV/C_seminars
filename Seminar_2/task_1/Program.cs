// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
Console.WriteLine("Введите 3х значное число: ");
string num = (Console.ReadLine());
if (num.Length == 3)
{   bool result = int.TryParse(num, out int number);
    if (result == true)
        {
            int n = (number / 10) % 10;
            Console.WriteLine("Втарая цифра числа: " + n);
        }
    else Console.WriteLine("Введенные вами данные не являются числом!!!");
}
else Console.WriteLine("Введенные вами данные не являются числом или это не 3х значное число.");