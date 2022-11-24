// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kvadro(double n)
{
    int i = 1;
    while (i <= n)
    {
        Console.Write(i * i * i + ", ");
        i++;
    }
}
double num;
double number;
Console.Write("Введите число: ");
num = Convert.ToDouble(Console.ReadLine());
if (num < 0) number = num * (-1);
else number = num;
Kvadro(number);