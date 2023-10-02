/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void minRow(int[] array)
{
    int minElement = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[minElement]) minElement = i;
    }
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {(minElement + 1)}");
}

int[] SumRous(int[,] array)
{
    int size = array.GetLength(0);
    int[] arraySum = new int[size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arraySum[i] = sum;
    }
    return arraySum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int rows = WorkWithUser("Введите количество строк массива: ");
int columns = WorkWithUser("Введите количество столбцов массива: ");
int min = WorkWithUser("Введите минимальный элемент массива: ");
int max = WorkWithUser("Введите максимальный элемент массива: ");
int[,] array = Array(rows, columns, min, max);
int[] arraySum = SumRous(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Массив сумм каждой из строк: {string.Join(" ", SumRous(array))}");
minRow(arraySum);