/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

void inputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble(), 2);
}

void releaseArray (double[] array)
{
    int i = 0;
    double max = array[i];
    double min = array[i];
    while (i < array.Length)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
        i++;
    }
    Console.WriteLine($"макс - мин = {max} - {min } = {Math.Round(max - min, 2)}");
}

Console.Write("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
double[] array = new double[numberOfElements];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
releaseArray(array);