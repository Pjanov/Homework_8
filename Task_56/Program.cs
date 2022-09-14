//                                          Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов. Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

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

void SumStringMatrix(int[,] array) // выводит строку с наименьшей суммой элементов  в массиве
{
    int index = 0, minsum = 0;
    for (int y = 0; y < array.GetLength(0); y++)
    {
        int sum = 0;
        for (int x = 0; x < array.GetLength(1); x++)
        {
            sum += array[y, x];
        }
        // Console.WriteLine($"Сумма {y + 1} строки = {sum}");
        if (y == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = y;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {index + 1}. ");
}

int[,] array = FillArray2(4, 4, 1, 9);
PrintArray2(array);
SumStringMatrix(array);
