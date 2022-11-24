// 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Сoordinates(double numb1, double numk1, double numb2, double numk2)
{
    double xElement = 0;
    double yElement = 0;

    xElement = (numb2 - numb1) / (numk1 - numk2);
    yElement = numk1 * xElement + numb1;
    Console.WriteLine($"точка пересечения ({xElement} : {yElement})");
}

Console.Write("Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Сoordinates(b1, k1, b2, k2);
