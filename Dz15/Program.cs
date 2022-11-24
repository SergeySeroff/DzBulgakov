/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

Console.Write("Введите число от 1 до 7: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if(n1==1) Console.Write("нет");
if(n1==2) Console.Write("нет");
if(n1==3) Console.Write("нет");
if(n1==4) Console.Write("нет");
if(n1==5) Console.Write("нет");
if(n1==6) Console.Write("да");
if(n1==7) Console.Write("да");
if(n1<1) Console.Write("введите число от 1 до 7");
if(n1>7) Console.Write("введите число от 1 до 7");