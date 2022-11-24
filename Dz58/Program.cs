// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void WorkMass(int[,] OneMartrix, int[,] TwoMartrix, int[,] ExitMatrix)
{
  for (int i = 0; i < ExitMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ExitMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < OneMartrix.GetLength(1); k++)
      {
        sum += OneMartrix[i,k] * TwoMartrix[k,j];
      }
      ExitMatrix[i,j] = sum;
    }
  }
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] OneMass = CreateMatrixRndInt(m, n, 1, 2);
PrintMatrix(OneMass);
Console.WriteLine("");

Console.Write("Введите количество строк массива: m=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] TwoMass = CreateMatrixRndInt(a, b, 1, 2);
PrintMatrix(TwoMass);
Console.WriteLine("");

int[,] resultMass = new int[m,b];
WorkMass(OneMass,TwoMass,resultMass);
PrintMatrix(resultMass);