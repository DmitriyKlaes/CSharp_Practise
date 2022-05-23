/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] fillArray(int length, int dev)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-dev, dev + 1);
    }
    return result;
}
int IndexOf(int[] collection, int borderA, int borderB)
{
    int position = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= borderA && collection[i] <= borderB)
        {
            position++;
        }
    }
    return position;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int[] array = fillArray(123,200);
PrintArray(array);
int count = IndexOf(array,10,99);
Console.Write($" -> {count} совпадений");