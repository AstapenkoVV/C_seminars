// Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
string num = (Console.ReadLine());
bool result = int.TryParse(num, out int number);
if (result == true)
    {
        if (number%2 == 0)
        Console.WriteLine("Число " + number + " делится на два без остатка");
        else Console.WriteLine("Число " + number + " НЕ делится на два без остатка");    }
else Console.WriteLine("Введенные вами данные не являются числами, проверка на четность невозможна!!!");