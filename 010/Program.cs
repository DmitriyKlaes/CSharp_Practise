/*
16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8, 9  ->  нет
*/

Console.Write("Введите два числа: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
int NumberTwo = Convert.ToInt32(Console.ReadLine());
if (NumberOne*NumberOne == NumberTwo || NumberTwo*NumberTwo == NumberOne)
{
  Console.WriteLine($"Ваши числа {NumberOne} и {NumberTwo} прошли тест на психологическую совместимость квадратности");  
}
else
{
    Console.WriteLine($"Поздравляю, ВЫ КУБ! Ваши числа {NumberOne} и {NumberTwo} не прошли тест на психологическую совместимость квадратности");  
}