/*
Напишите программму, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
78 -> 8
15 -> 5
92 -< 9
*/

int randomNumber = new Random().Next(10,100);

int numberOne = randomNumber % 10;
int numberTwo = randomNumber / 10;
System.Console.Write($"У числа {randomNumber} большая цифра ");
if (numberOne > numberTwo)
{
    System.Console.Write(numberOne);
}
else
{
    System.Console.Write(numberTwo);
}
