/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int summDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + summDigits(number / 10);
}
int result = summDigits(453);
Console.WriteLine(result);

