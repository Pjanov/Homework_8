//                                      Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
// Результирующая матрица будет:
//  18 20
//  15 18

Console.Clear();

int[,] FillArray2(int line, int col, int min, int max) //заполняет двумерный массив случайными числами от 1 до 9
{
    int[,] matr = new int[line, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

void PrintArray2(int[,] array) //выводит в консоль двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2) // произведение двух матриц
{
    int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); ++i)
        for (int j = 0; j < array2.GetLength(0); ++j)
            for (int k = 0; k < array2.GetLength(1); ++k)
                res[i, k] += array1[i, j] * array2[j, k];
    return res;

}

int[,] array1 = FillArray2(2, 2, 1, 4);
int[,] array2 = FillArray2(2, 2, 1, 4);
PrintArray2(array1);
Console.WriteLine();
PrintArray2(array2);
Console.WriteLine();
int[,] res = MatrixMultiplication(array1, array2);
PrintArray2(res);
