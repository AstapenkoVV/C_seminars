// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное 
// из этих чисел.

Console.WriteLine("Введите первое число: ");
string num1 = (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
string num2 = (Console.ReadLine());
Console.WriteLine("Введите третье число: ");
string num3 = (Console.ReadLine());
bool result1 = int.TryParse(num1, out int number1);
bool result2 = int.TryParse(num2, out int number2);
bool result3 = int.TryParse(num3, out int number3);
if (result1 == true && result2 == true && result3 == true)
    {
        if ((number1 > number2) && (number1 > number3))
        Console.WriteLine("Max = " + number1);
        else if ((number2 > number1) && (number2 > number3))
        Console.WriteLine("Max = " + number2);
        else Console.WriteLine("Max = " + number3);
    }
else Console.WriteLine("Введенные вами данные не являются числами, сравнение невозможно!!!");