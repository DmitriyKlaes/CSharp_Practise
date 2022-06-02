/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] GetNewArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = i; j < column; j++)
        {
            result[i, j] = new Random().Next(1, 20);
        }
    }
    return result;
}

int[,] RowsToColumns(int[,] arrayToChange)
{
    int[,] result = new int[arrayToChange.GetLength(1), arrayToChange.GetLength(0)];
    for (int j = 0; j < arrayToChange.GetLength(1); j++)
    {
        for (int i = 0; i < arrayToChange.GetLength(0); i++)
        {
            result[i, j] = arrayToChange[j, i];
        }
    }
    return result;
}

void RowsToColumnsIn(int[,] arrayToChange)
{
    int temp;
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
    {
        for (int j = i; j < arrayToChange.GetLength(1); j++)
        {
            temp = arrayToChange[i, j];
            arrayToChange[i, j] = arrayToChange[j, i];
            arrayToChange[j, i] = temp;
        }
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

int[,] baseArray = GetNewArray(5, 5);
Print2DArray(baseArray);
Console.WriteLine();
if (baseArray.GetLength(0) == baseArray.GetLength(1))
{
    RowsToColumnsIn(baseArray);
    Print2DArray(baseArray);
}
else
{
    Console.WriteLine("Так нельзя");
}