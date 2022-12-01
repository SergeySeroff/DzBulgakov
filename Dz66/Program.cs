// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NaturalSum(int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма от M до N -> {sum}"); 
        return;
    }
    sum = sum + (numM++);
    NaturalSum(numM, numN, sum);
}

Console.Clear();
Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalSum(m, n, 0);
