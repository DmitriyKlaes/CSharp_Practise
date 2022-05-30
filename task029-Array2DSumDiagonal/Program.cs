/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int SumElementsDiagonal(int[,] arrayToSumm)
{
    int result = 0;
    for (int i = 0, j = 0; i < arrayToSumm.GetLength(0); i++, j++)
    {
        result = result + arrayToSumm[i, j];
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write("[ ] ");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[" + i + "] ");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]  ");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ResetColor();
            }
            Console.Write(arrayToPrint[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] array = Get2DArray(5, 5);
Print2DArray(array);
int sum = SumElementsDiagonal(array);
Console.WriteLine($"\nСумма элементов главной диагонали = {sum}");