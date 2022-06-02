/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

int[,] GetNewArray(int row, int column)
{
    int[,] result = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i,j] = new Random().Next(1,20);
        }
    }
    return result;
}

void ArrayStringExchange(int[,] arrayToExchange)
{
    int temp;
    for (int i = 0; i < arrayToExchange.GetLength(1); i++)
    {
        temp = arrayToExchange[0,i];
        arrayToExchange[0,i] = arrayToExchange[arrayToExchange.GetLength(0)-1,i];
        arrayToExchange[arrayToExchange.GetLength(0)-1,i] = temp;
    }

}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[X]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine("");
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] baseArray = GetNewArray(5,5);
Print2DArray(baseArray);
Console.WriteLine();
ArrayStringExchange(baseArray);
Print2DArray(baseArray);