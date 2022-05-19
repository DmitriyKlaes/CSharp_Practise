/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int GetSomOfSeries(int from, int to)
{
    int result = 0;
    for (int i = from; i <= to; i++)
    {
        result += i;
    }
    return result;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int sumOrSeries = GetSomOfSeries(1,number);
System.Console.WriteLine(sumOrSeries);
