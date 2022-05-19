/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int multi = 1;
for (int i = 1; i <= number; i++)
{
    multi *= i;
}
System.Console.WriteLine(multi);