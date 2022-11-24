// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());;
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());;
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());;

int max = a;
if(b>max) max=b;
if(c>max) max=c;

Console.WriteLine($"{max} является максимальным");