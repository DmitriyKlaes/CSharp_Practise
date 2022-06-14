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
    for (int i = 0; i < arrayData.Length; i++)
    {
        for (int j = arrayData[i] - 1; j >= 0; j--, index++)        
        {
            int temp = index * Convert.ToInt32(Math.Pow(2, 3));
            result[i] = arrayInfo[j] * 
        }
    }

    return result;
}

int[] info = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] data = { 2, 3, 3, 1 };






int ToDicimal(int[] array, int number, int count = 0)
{
    int[] result = new int[number];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[i];
    }

}
















