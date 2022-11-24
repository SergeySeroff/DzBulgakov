// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num / 10 % 10;

Console.Write(result);