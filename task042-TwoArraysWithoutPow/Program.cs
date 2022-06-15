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

int[] DecimialNumbersArray(int[] arrayInfo, int[] arrayData)
{
    int[] result = new int[arrayData.Length];
    int index = 0;
    int basePowerIndex = 1;
    for (int i = 0; i < arrayData.Length; i++)
    {
        for (int j = 0; j < arrayData[i]; j++, index++)
        {
            for (int k = 0; k < j; k++)
            {
                basePowerIndex = basePowerIndex * 2;
            }
            //if (i == 0)
            //{
            //    basePowerIndex = 1;
            //}
            result[i] = result[i] + arrayInfo[index] * basePowerIndex;
            basePowerIndex = 1;
        }
    }
    return result;
}

int[] info = { 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 3, 2, 3, 3, 1 };
int[] resultArray = DecimialNumbersArray(info, data);
string stringResultArray = string.Join(", ", resultArray);
System.Console.WriteLine(stringResultArray);