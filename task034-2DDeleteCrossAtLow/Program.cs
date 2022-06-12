/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] GetNewArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

int FindLowerElement(int[,] arrayForFind)
{
    int result = arrayForFind[0, 0];
    for (int i = 0; i < arrayForFind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForFind.GetLength(1); j++)
        {
            if (arrayForFind[i, j] < result)
            {
                result = arrayForFind[i, j];
            }
        }
    }
    return result;
}

/*
int[,] DeleteRowsAndColumns(int[,] arrayForDelete, int lowerElement)
{
    int[,] result = new int[arrayForDelete.GetLength(0) - 1, arrayForDelete.GetLength(1) - 1];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < arrayForDelete.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForDelete.GetLength(1); j++)
        {
            if (arrayForDelete[i, j] == lowerElement)
            {
                indexRow = i;
                indexColumn = j;
                break;
            }
        }
    }
    for (int i = 0, tempRow = 0; i < result.GetLength(0); i++, tempRow++)
    {
        for (int j = 0, tempColumn = 0; j < result.GetLength(1); j++, tempColumn++)
        {
            if (tempRow == indexRow)
            {
                tempRow++;

            }
            if (tempColumn == indexColumn)
            {
                tempColumn++;

            }
            result[i, j] = arrayForDelete[tempRow, tempColumn];
        }
    }
    return result;
}
*/

void DeleteDuplicateElements(string text)
{
    int index = 0;
    while (true)
    {
        var temp = text[index].ToString();
        text = text.Replace(temp, "");
        text = text.Insert(index, temp);
        index++;
        if (text.Length - 1 < index)
        {
            break;
        }
    }
}

int[,] DeleteRowsAndColumns(int[,] arrayForDelete, int lowerElement)
{
    string indexLowerRowList = String.Empty;
    string indexLowerColumnList = String.Empty;
    int countLowers = 0;
    for (int i = 0; i < arrayForDelete.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForDelete.GetLength(1); j++)
        {
            if (arrayForDelete[i, j] == lowerElement)
            {
                //indexLowerRow = i;
                //indexLowerColumn = j;
                //if ()
                indexLowerRowList = $"{i}";
                indexLowerColumnList = $"{j}";

                //indexRow = i;
                //indexColumn = j;
                //break;
                countLowers++;
            }
        }
    }

    DeleteDuplicateElements(indexLowerRowList);
    DeleteDuplicateElements(indexLowerColumnList);

    int[] indexLowerRowArray = indexLowerRowList.Select(x => x - '0').ToArray();
    int[] indexLowerColumnArray = indexLowerColumnList.Select(x => x - '0').ToArray();

    int resultArrayRow = arrayForDelete.GetLength(0);
    int resultArrayColumn = arrayForDelete.GetLength(1);

    if (resultArrayRow - indexLowerRowArray.Length > 1 && resultArrayColumn - indexLowerColumnArray.Length > 1)
    {
        resultArrayRow = arrayForDelete.GetLength(0) - indexLowerRowArray.Length;
        resultArrayColumn = arrayForDelete.GetLength(1) - indexLowerColumnArray.Length;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Удаление строк невозможно... ничего не останется!");
        Console.ResetColor();
        return arrayForDelete;
    }

    int[,] result = new int[resultArrayRow, resultArrayColumn];

    for (int i = 0, tempRow = 0; i < result.GetLength(0); i++, tempRow++)
    {
        for (int j = 0, tempColumn = 0; j < result.GetLength(1); j++, tempColumn++)
        {
            if (tempRow == indexRow)
            {
                tempRow++;

            }
            if (tempColumn == indexColumn)
            {
                tempColumn++;

            }
            result[i, j] = arrayForDelete[tempRow, tempColumn];
        }
    }
    return result;
}

void Print2DArrayColor(int[,] arrayToPrint, int lowerElement)
{
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (arrayToPrint[i, j] == lowerElement)
            {
                indexRow = i;
                indexColumn = j;
                break;
            }
        }
    }
    Console.Write($"\n[X]\t");
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
            if (indexRow == i || indexColumn == j)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write(arrayToPrint[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"\n[X]\t");
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

int arrayRow = 7;
int arrayColumn = 7;
int[,] baseArray = GetNewArray(arrayRow, arrayColumn);
int lowerElement = FindLowerElement(baseArray);
Print2DArrayColor(baseArray, lowerElement);
Console.WriteLine($"\nНаименьший элемент в массиве = {lowerElement}");
int[,] resultArray = DeleteRowsAndColumns(baseArray, lowerElement);
Print2DArray(resultArray);

/*
//int[] array = new int [4];
string text = "1234";
int[] arr = text.Select(x => x - '0').ToArray();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = text[i] - 48;
//}
string result = string.Join(", ", arr);
System.Console.WriteLine(result);
*/
/*
void Main()
{
    string str = "34,,534aann5345ghkc34535fhfghfgcbvbcvb";
    Console.WriteLine(str);
    int i = 0;
    while (true)
    {
        var tmp = str[i].ToString();
        str = str.Replace(tmp, "");
        str = str.Insert(i, tmp);
        i++;
        if (str.Length - 1 < i)
            break;
    }
    Console.WriteLine(str);
    Console.WriteLine();
}
Main();
*/
