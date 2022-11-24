/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
               Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

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

void SumElement(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1)
        {
            count = count + arr[i];
        }
    }
    Console.Write(count);
}

Console.Write("Imput size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value of element: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value of element: ");
int maxElement = Convert.ToInt32(Console.ReadLine());

int[] array = CreatRendomArray(size, minElement, maxElement);
PrintArray(array);
Console.Write($" sum element = ");
SumElement(array);

