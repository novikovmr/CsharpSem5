/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void releaseArray(int[] array)
{
    int countEven =0;
    int countOdd =0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            countEven += 1;
        else 
            countOdd += 1;
    Console.WriteLine($"Количество чётных чисел - {countEven}, нечетных - {countOdd}");
}

Console.Write("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberOfElements];
inputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
releaseArray(array);