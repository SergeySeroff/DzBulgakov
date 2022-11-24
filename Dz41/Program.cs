// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

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
    for (int i = 0; i < arr.Length; i++)  // название(метода, массива).Length <-- определит нашу длинну массива
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

int PositiveNum(int[] arry)
{
    int count = 0;
    for (int i = 0; i < arry.Length; i++)
    {
        if (arry[i] > 0)
        {
            arry[i] = 1;
            count += arry[i];
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int mass = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: ");
int massMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: ");
int massMax = Convert.ToInt32(Console.ReadLine());
int[] posiive = CreatRendomArray(mass, massMin, massMax);
PrintArray(posiive);
int num = PositiveNum(posiive);
Console.Write($" -> {num} чисел(а) больше 0 ввёл пользователь");