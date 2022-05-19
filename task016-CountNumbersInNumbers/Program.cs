/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("введите число");

int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number > 0)
{
    number /= 10;
    count++;
}
System.Console.WriteLine(count);