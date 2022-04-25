/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> 
*/

Console.WriteLine("Введите число: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA * numberA;
if (result == numberB)
Console.WriteLine("УРА");
else Console.WriteLine("Попробуй еще");