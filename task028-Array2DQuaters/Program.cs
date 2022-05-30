/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[,] Get2DArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void FindForMultiplie(int[,] arrayForMultiplie)
{
    for (int i = 2; i < arrayForMultiplie.GetLength(0); i = i + 2)
    {
        for (int j = 2; j < arrayForMultiplie.GetLength(1); j = j + 2)
        {
            arrayForMultiplie[i, j] = arrayForMultiplie[i, j] * arrayForMultiplie[i, j];
        }
    }
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write("[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[" + i + "]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] baseArray = Get2DArray(5, 5);
Print2DArray(baseArray);
Console.WriteLine();
FindForMultiplie(baseArray);
Print2DArray(baseArray);