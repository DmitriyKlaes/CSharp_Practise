/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

System.Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(System.Console.ReadLine());

if (numberOne % numberTwo == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    int div = numberOne % numberTwo;
    System.Console.WriteLine($"не кратно, остаток {div}");
}