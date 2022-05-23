/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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
int[] arrayChange(int[] arrayForChange)
{
    int[] result = new int[arrayForChange.Length];
    for (int i = 0; i < arrayForChange.Length; i++)
    {
        result[i] = arrayForChange[i] * -1;
    }
    return result;
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
int[] array = fillArray(10,10);
int[] arrayResult = arrayChange(array);
PrintArray(array);
PrintArray(arrayResult);