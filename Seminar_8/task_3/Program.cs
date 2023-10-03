/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] NewArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];    
            }
        }
    }
    return result;
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
int[,] array1 = Array(rows, columns, min, max);
int[,] array2 = Array(rows, columns, min, max);
Console.WriteLine("Матрица 1: ");
PrintArray(array1);
Console.WriteLine("Матрица 2: ");
PrintArray(array2);
Console.WriteLine("Произведение 2х матриц: ");
PrintArray(NewArray(array1, array2));