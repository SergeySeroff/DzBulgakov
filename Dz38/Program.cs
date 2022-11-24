// Задача 38:Задайте массив вещественных чисел. Найдите разницу между 
//           максимальным и минимальным элементов массива.
//           [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

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
    Console.WriteLine("]");
}

int Count(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] <= max && array[i] >= min) count++;
        if(array[i] > max) array[i] = max;
        else array[i] = min; 
    }
    return max - min;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный размер массива: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный размер массива: ");
int maxElement = Convert.ToInt32(Console.ReadLine());

int[] array = CreatRendomArray(size, minElement, maxElement);
PrintArray(array);
Console.Write("Введите минимальное значение заданного массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение заданного массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write($"Разница между {min} и {max} элементами массива равно {Count(array,min,max)}");
