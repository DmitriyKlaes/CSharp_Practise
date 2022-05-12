/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.Write("Введите число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
if (numberOne % 7 == 0 && numberOne % 23 == 0)
{
Console.WriteLine($"Введеное Вами число {numberOne}, подходит под данные условия");
}
else
{
    Console.WriteLine($"Введеное Вами число {numberOne}, не подходит под данные условия");
}
