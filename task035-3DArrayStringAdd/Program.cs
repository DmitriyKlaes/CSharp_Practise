/*
*/

int[] numbers = new int[100];
int GetUniqNumber()
{
    bool uniq = false;
    int result = new int();
    while (!uniq)
    {
        result = new Random().Next(10, 100);
        if (numbers[result] == 0)
        {
            numbers[result] = 1;
            uniq = true;
            break;
        }
        else
        {
            int countUniq = GetNumberOfUniq(numbers);
            if (countUniq == 90)
            {
                Console.WriteLine("Все двузначные числа использованы");
                break;
            }
        }
    }
    return result;
}

int GetNumberOfUniq(int[] numbers)
{
    int result = new int();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        if (numbers[i] == 1)
        {
            result++;
        }
    }
    return result;
}

int[,,] Generate3DArray(int rowsNumber, int colsNumber, int depthNumber)
{
    int[,,] result = new int[rowsNumber, colsNumber, depthNumber];
    for (int i = 0; i < rowsNumber; i++)
    {
        for (int j = 0; j < colsNumber; j++)
        {
            for (int z = 0; z < depthNumber; z++)
            {
                result[i, j, z] = GetUniqNumber();
            }
        }
    }
    return result;
}

void print3DArray(int[,,] arrayToPrint, int oneLineLength = 3)
{
    int currentLength = 0;
    for (int i = 0; i < arrayToPrint.GetLongLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLongLength(1); j++)
        {
            for (int z = 0; z < arrayToPrint.GetLongLength(2); z++)
            {
                Console.Write($"[{i},{j},{z}: {arrayToPrint[i, j, z]}]\t");
                if (currentLength == oneLineLength)
                {
                    Console.WriteLine();
                    currentLength = 0;
                }
                currentLength++;
            }
        }
    }
}

const int rowsNumber = 3;
const int colsNumber = 3;
const int depthNumber = 2;
int[,,] generated3DArray = Generate3DArray(rowsNumber, colsNumber, depthNumber);
print3DArray(generated3DArray);