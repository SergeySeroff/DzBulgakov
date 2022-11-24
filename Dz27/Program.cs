// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumb(int a)
{
    int count = 0;
    while (a > 0)
    {
        count = count + a % 10;
        a = a / 10;
    }
    return count;
}
Console.Write("Ввидите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumNumb(num);
Console.WriteLine(result);