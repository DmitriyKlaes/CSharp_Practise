/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
string IndexOf(int[] collection, int find)
{
    string position = "совпадения не найдены";
    for (int i = 0; i < collection.Length; i++)
    {
        if(Math.Abs(collection[i]) == Math.Abs(find))
        {
            position = "совпадения есть";
        }
    }
    return position;
}
int[] array = fillArray(10,10);
PrintArray(array);
int wish = 5;
string find = IndexOf(array,wish);
Console.WriteLine($"С элементом {wish} {find}");