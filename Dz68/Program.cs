// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ackerman(m - 1, Ack(m, n - 1));
}

Console.Clear();
Console.Write("Введите начальное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int akerman = Ackerman(m, n);

Console.Write($"A(m,n) = {akerman}");