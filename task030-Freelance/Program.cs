int[,] GenerateArray(int rowLength, int colLength, int minBorder = 0, int maxBorder = 20)
{
    int[,] generateArray = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            generateArray[i, j] = new Random().Next(minBorder, maxBorder + 1);
        }
    }
    return generateArray;
}
void PrintHederOfNumbers(int length, string name = "")
{
    if (string.IsNullOrEmpty(name))
    {
        System.Console.WriteLine($"---------------{name}--------------");
    }
    Console.WriteLine($"[ ]\t");
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"[{i}]\t");
    }
    Console.WriteLine();
}
void Print2DArray(int[,] arrayToPrint, string name = "")
{
    PrintHederOfNumbers(arrayToPrint.GetLength(1),name);
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] generatedArray = GenerateArray(7,5);
Print2DArray(generatedArray);