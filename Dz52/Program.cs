// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        Console.WriteLine();
    }
}

double[] ArithmeticElemnt(int[,] matrix)
{
    double[] sumArit = new double[matrix.Length];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
            sumArit[j] += matrix[i, j];
        Console.Write("{0,6:F1}", sumArit[j] / matrix.GetLength(0));
    }
    return sumArit;
}

Console.Write("Введите размеры массива кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размеры массива кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, 1, 9);
PrintMatrix(array2D);
double[] result = ArithmeticElemnt(array2D);


