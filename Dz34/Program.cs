// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreatRendomArray(int size, int min, int max)

{
    int[] array = new int[size]; // обязательная строка для выделения памяти!!!
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)  // название(метода, массива).Length <-- определит нашу длинну массива
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int KratnoTwo(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Imput size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value of element: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value of element: ");
int maxElement = Convert.ToInt32(Console.ReadLine());

int[] array = CreatRendomArray(size, minElement, maxElement);
PrintArray(array);
int kratno = KratnoTwo(array);
Console.Write($" number of even numbers = {kratno}");