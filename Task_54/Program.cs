//                                             Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива. Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
// В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2

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

void PrintArray2(int[,] matr) //выводит в консоль двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array) // упорядочит по убыванию
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1) - 1; x++)
        {
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[y, m] < array[y, m + 1])
                {
                    int temp = 0;
                    temp = array[y, m];
                    array[y, m] = array[y, m + 1];
                    array[y, m + 1] = temp;
                }
            }
        }
    }
}

int[,] array = FillArray2(4, 4, 1, 9);
PrintArray2(array);
Console.WriteLine();
SortArray(array);
PrintArray2(array);
