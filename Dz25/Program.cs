// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Stepen(double num, double num1)
{
    double result = 1;
    for (int i = 0; i < num1; i++)
    {
        result = result * num; // result *= num
    }
    return result;
}

Console.Write("Введите число a=");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b=");
double b = Convert.ToInt32(Console.ReadLine());

double stepen = Stepen(a, b);
Console.Write($"число {a} в натуральную степень {b} = {stepen}");