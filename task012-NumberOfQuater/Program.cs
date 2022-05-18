/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите номер четверти");
int quart = Convert.ToInt32(Console.ReadLine());

if (quart == 1)
{
    Console.WriteLine("y > 0; x > 0");
}
else if (quart == 2)
{
    Console.WriteLine("y < 0; x > 0");
}
else if (quart == 3)
{
    Console.WriteLine("y < 0; x < 0");
}
else if (quart == 4)
{
    Console.WriteLine("y > 0; x < 0");
}
else
{
    Console.WriteLine("Неверный ввод");
}