/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

bool Palindrom(int num)
{
    int count = 0;
    int num2 = num;
    while (num2 > 0)
    {
        count = count * 10 + num2 % 10;
        num2 = num2 / 10;
    }
    if (count == num) return true;
    else return false;
}

Console.Write("Введите число: ");
int drom = Convert.ToInt32(Console.ReadLine());
bool palindrom = Palindrom(drom);

if (palindrom) Console.Write("палиндром");
else Console.Write("не палидром");

/*
bool Palindrom(string num)
{
    for (int i = 1, j = num.Length - 1; i < j; i++, j--)
        if (num[i] != num[j])
            return false;
        return true;
}
string drom;
Console.Write("Введите число: ");
drom = Console.ReadLine();


if (Palindrom(drom)) Console.Write("палиндром");
else Console.Write("не палидром");
Console.Write(" ");
*/