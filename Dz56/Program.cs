// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] array2D = CreateMatrixRndInt(m, n, 1, 9);
PrintMatrix(array2D);
Console.WriteLine("");
int minRows = 0;
int sumRows = SumLineElements(array2D, 0);
for (int i = 1; i < array2D.GetLength(0); i++)
{
  int tempSumRows = SumLineElements(array2D, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minRows = i;
  }
}
Console.WriteLine($"номер строки с наименьшей суммой элементов: {minRows+1} строка");