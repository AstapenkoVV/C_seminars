// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double[] ArrayNum(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return array;
}
void FindMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    result = Math.Round(max - min, 2);
    Console.WriteLine($"Массив: {string.Join<double>(", ", array)}");
    Console.WriteLine($"Разница между максимальным: {max} и минимальным: {min} элементами массива = {result}");
}

int length = WorkWithUser("Введите размер массива: ");
int min = WorkWithUser("Введите минимальный элемент массива: ");
int max = WorkWithUser("Введите максимальный элемент массива: ");
double[] array = ArrayNum(length, min, max);
FindMaxMin(array);