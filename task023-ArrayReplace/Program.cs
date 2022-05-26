


int [] GenerateArray(int length, int lowerBorder, int upperBorder)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(lowerBorder,upperBorder + 1);
    }
    return result;
}

void printArray (int[] arrayToPrint, string name = "")
{
    Console.ForegroundColor=ConsoleColor.Green;
    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"Массив {name}");
    }
    Console.WriteLine("---------------------------------------------");
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
}

int[] reverseArray(int[] arrayToReverse)
{
    int[] result = new int[arrayToReverse.Length];
    for (int i = 0; i < arrayToReverse.Length; i++)
    {
        result[i] = arrayToReverse[arrayToReverse.Length - 1 - i];
    }
    return result;
}
Console.Clear();
int[] arrayToReverse = GenerateArray(5,-10,10);
printArray(arrayToReverse, "Начальный");
int[] reversedArray = reverseArray(arrayToReverse);
printArray(reversedArray, "Перевернутый");