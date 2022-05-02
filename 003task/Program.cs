/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = new Random().Next(-99, 100);
        Console.Write(array[index] + " ");
        index++;
    }
}

int[] array = new int[8];

FillArray(array);
Console.WriteLine();
