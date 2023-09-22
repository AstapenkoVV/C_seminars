// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void CounterNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum++;
    }
    Console.WriteLine($"Массив: {string.Join<int>(" ", array)}");
    Console.WriteLine($"Количество чётных чисел в массиве: {sum}");
}

int length = WorkWithUser("Введите размер массива: ");
int min = WorkWithUser("Введите минимальный элемент массива: ");
int max = WorkWithUser("Введите максимальный элемент массива: ");
int[] array = ArrayNum(length, min, max);
CounterNumbers(array);