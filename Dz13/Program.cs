/*
Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
*/
Console.Write("Введите число ");
int n1 = Convert.ToInt32(Console.ReadLine());

while(n1 < 99) 
{
    Console.WriteLine("третьей цифры нет");
    return;
}
    
while (n1 > 999)
{
    n1 = n1 / 10;
}
int result = n1 % 10;

Console.Write(result);