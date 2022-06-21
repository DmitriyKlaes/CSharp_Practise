/*
Задача: Заполните спирально массив 4 на 4.

1  2  3  4
12 13 14 5
11 16 15 6
10  9  8 7
*/

int[,] SpiralFill2DArray(int row, int column)
{
    int[,] result = new int[row, column];
    int element = 1;
    int index = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = i; j < result.GetLength(1) - i; j++)
        {
            result[i, j] = element;
            element++;
            index = j;
        }
        for (int k = i + 1; k < result.GetLength(0) - i; k++)
        {
            result[k, index] = element;
            element++;
        }
        for (int l = result.GetLength(1) - 2 - i; l >= i; l--)
        {
            result[index, l] = element;
            element++;
        }
        for (int m = index - 1; m > i; m--)
        {
            result[m, i] = element;
            element++;
        }
    }
    return result;
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

int arrayRow = 5;
int arrayColumn = 4;
int[,] arrayResult = SpiralFill2DArray(arrayRow, arrayColumn);
Print2DArray(arrayResult);