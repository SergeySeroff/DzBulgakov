// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (a > max) max = a;
if (b > max) 
{
    max = b;
}
else min = b;

Console.WriteLine($"максимальное число {max} минимальное число {min}");