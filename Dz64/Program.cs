// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturslNambers(int num1, int num2)
{
    
    if(num1 < num2)
    {
        Console.Write($"{num1}, ");
        NaturslNambers(num1 + 1, num2);
    }
    if(num1 > num2)
    {
        Console.Write($"{num1}, ");
        NaturslNambers(num1 - 1, num2);
    }
    if(num1 == num2) Console.Write($"{num1} \"");
}

Console.Clear();
Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("\" ");
NaturslNambers(m,n);