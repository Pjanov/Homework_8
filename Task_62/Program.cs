//                                        Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07

Console.Clear();

void FillArraySpiral(int[,] array, int n) // заполнит спирально массив n x n
{
    int y = 0, x = 0;
    int value = 1;
    for (int i = 0; i < n * n; i++)
    {
        int k = 0;
        do array[y, x++] = value++; 
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[y++, x] = value++;
        for (k = 0; k < n - 1; k++) array[y, x--] = value++;
        for (k = 0; k < n - 1; k++) array[y--, x] = value++;
        ++y; ++x;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray2(int[,] matr) //выводит в консоль двумерный массив
{
    for (int y = 0; y < matr.GetLength(0); y++)
    {
        for (int x = 0; x < matr.GetLength(1); x++)
        {
            if (matr[y, x] < 10)
            {
                Console.Write($"0{matr[y, x]} ");
            }
            else
            {
                Console.Write($"{matr[y, x]} ");
            }
        }
        Console.WriteLine();
    }
}

int n = 4;
int[,] array = new int[n, n];
FillArraySpiral(array, n);
PrintArray2(array);
