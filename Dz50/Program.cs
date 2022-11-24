// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве,и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void PositionElement(int[,] matrix, int num1, int num2)
{
    if (num1 < 0 | num1 > matrix.GetLength(0) - 1 | num2 < 0 | num2 > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[num1, num2]);
    }
}

Console.Write("Введите размеры массива кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размеры массива кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, 1, 50);
PrintMatrix(array2D);

Console.Write("Введите значение строки: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
PositionElement(array2D, pos1, pos2);
