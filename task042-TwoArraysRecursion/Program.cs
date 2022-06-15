/*
Задача 72: Заданы 2 массива: info и data. 
В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
Напишите программу, которая составит массив десятичных представлений 
чисел массива data с учётом информации из массива info.

входные данные:
info = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }
data = { 2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

int[] DecimialNumbersRecursion(int[] arrayInfo, int[] arrayData, int length = 0)
{
    int[] result = new int[arrayData.Length];
    int index = 0;
    for (int i = 0; i < arrayData.Length; i++)
    {
        for (int j = arrayData[i] - 1; j >= 0; j--, index++)
        {
            result[i] = result[i] + arrayInfo[index] * Convert.ToInt32(Math.Pow(2, j));
        }
    }
    if (length == 1)
    {
        System.Console.WriteLine("конец");
        return result;
    }
    //return DecimialNumbersRecursion(arrayInfo, arrayData, length + 1);            //  DecimialNumbersRecursion(arrayInfo, arrayData);
}

int[] info = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 2, 3, 3, 1 };
//int[] result = new int[data.Length];
int[] result = DecimialNumbersRecursion(info, data);
string stringResultArray = string.Join(", ", result);
System.Console.WriteLine(stringResultArray);

void AllWordsFrom(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        AllWordsFrom(alphabet, word, length + 1);
    }
}
//AllWordsFrom("аисв", new char[2]);


/*
int[] DecimialNumbersArray(int[] arrayInfo, int[] arrayData)
{
    int[] result = new int[arrayData.Length];
    int index = 0;
    int basePowerIndex = 1;
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < arrayData[i]; j++, index++)
        {
            for (int k = j; k < arrayData[i] - 1; k++)
            {
                basePowerIndex = basePowerIndex * 2;
            }
            result[i] = result[i] + arrayInfo[index] * basePowerIndex;
            basePowerIndex = 1;
        }
    }
    return result;
}

int[] info = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 2, 3, 3, 1 };
int[] resultArray = DecimialNumbersArray(info, data);
string stringResultArray = string.Join(", ", resultArray);
System.Console.WriteLine(stringResultArray);
*/