/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int releaseArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum += array[i];
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberOfElements];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма нечетных элементов массива: {releaseArray(array)}");