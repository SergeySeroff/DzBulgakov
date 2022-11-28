// Задача 60. Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


void CreateArray(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix3D.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3D.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3D.GetLength(2); z++)
            {
                matrix3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void WriteArray(int[,,] matr3D)
{
    for (int i = 0; i < matr3D.GetLength(0); i++)
    {
        for (int j = 0; j < matr3D.GetLength(1); j++)
        {
            for (int k = 0; k < matr3D.GetLength(2); k++)

                Console.Write($"{matr3D[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.Write("Введите размер массива: x=");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: y=");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: z=");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);
Console.WriteLine();