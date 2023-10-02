/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

int[,] ModiArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int indexMax = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, indexMax])
                    indexMax = k;
            }
            if (array[i, indexMax] == array[i, j])
                continue;

            int temp = array[i,j];
            array[i, j] = array[i, indexMax];
            array[i, indexMax] = temp;
        }
    }
    return array;
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
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ModiArray(array);
PrintArray(array);