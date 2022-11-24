// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine();

    }
}

void MinElement(int[,] element)
{
  for (int i = 0; i < element.GetLength(0); i++)
  {
    for (int j = 0; j < element.GetLength(1); j++)
    {
      for (int k = 0; k < element.GetLength(1) - 1; k++)
      {
        if (element[i, k] < element[i, k + 1])
        {
          int temp = element[i, k + 1];
          element[i, k + 1] = element[i, k];
          element[i, k] = temp;
        }
      }
    }
  }
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] array2D = CreateMatrixRndInt(m, n, 1, 9);
PrintMatrix(array2D);
Console.WriteLine("");
MinElement(array2D);
PrintMatrix(array2D);

