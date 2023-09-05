// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, 
// а какое меньшее.

Console.WriteLine("Введите первое число: ");
string num1 = (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
string num2 = (Console.ReadLine());
bool result1 = int.TryParse(num1, out int number1);
bool result2 = int.TryParse(num2, out int number2);
if (result1 == true && result2 == true)
    {
        if (number1 > number2)
        Console.WriteLine("Первое число больше второго! Max = " + number1);
        else Console.WriteLine("Второе число больше первого! Max = " + number2);
    }
else Console.WriteLine("Введенные вами данные не являются числами, сравнение невозможно!!!");