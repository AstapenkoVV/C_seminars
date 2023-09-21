// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] ArrayNum(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) 
    {
        array[i] = random.Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
}

int length = WorkWithUser("Введите размер массива: ");
int min = WorkWithUser("Введите начальный диапазон массива: ");
int max = WorkWithUser("Введите конечный диапазон массива: ");
int[] array = ArrayNum(length, min, max);
PrintArray(array);