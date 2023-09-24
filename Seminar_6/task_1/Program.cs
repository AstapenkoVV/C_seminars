// Задача 41: Пользователь вводит с клавиатуры 
// M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] WorkWithUser(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    string[] strArray = str.Split(", ");
    return strArray;
}

int[] TranslateArray(string[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
        newArray[i] = int.Parse(array[i]);
    return newArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i] + ", ");
}

void CountPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    Console.WriteLine($"{result} Больше 0 ввел пользователь.");
 /*    if (result % 1 == 0 && 
    result % 5 == 0 
    &&result % 6 == 0 
    &&result % 7 == 0 
    &&result % 8 == 0 
    &&result % 9 == 0) 
    Console.WriteLine(result + " чисел больше 0 ввёл пользователь");
    else if (result % 1 == 0) 
    Console.WriteLine(result + " число больше 0 ввёл пользователь");
    else Console.WriteLine(result + " числа больше 0 ввёл пользователь"); */
}

string[] array = WorkWithUser("Введите массив чисел через запятую (,): ");
int[] newArray = TranslateArray(array);
PrintArray(newArray);
Console.WriteLine();
CountPositive(newArray);