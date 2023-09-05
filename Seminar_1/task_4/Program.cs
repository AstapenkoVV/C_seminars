// Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает 
// все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
string num = (Console.ReadLine());
bool result = int.TryParse(num, out int number);
if (result == true)
    {
        for (int i = 2; i <= number; i++)
        {
            if ((i % 2 == 0 && i == number) || (i % 2 == 0 && i + 1 == number))
            Console.Write(" " + i);
            else if (i % 2 == 0)
            Console.Write(" " + i + ",");
        }
    }
else Console.WriteLine("Введенные вами данные не являются числами, проверка на четность невозможна!!!");