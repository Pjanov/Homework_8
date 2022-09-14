//                                          Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
//  66(0,0,0) 25(0,1,0)
//  34(1,0,0) 41(1,1,0)
//  27(0,0,1) 90(0,1,1)
//  26(1,0,1) 55(1,1,1)

Console.Clear();

void FillArray3(int[,,] array) // заполняет массив трехмерный не повторяющимеся числами
{
    int count = 10;
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[z, y, x] += count;
                count += 3;
            }
        }
    }
}

void PrintArray3(int[,,] array) // выводит индексы каждого элемента
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
FillArray3(array);
PrintArray3(array);
