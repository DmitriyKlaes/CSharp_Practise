/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100,1000);
System.Console.WriteLine(randomNumber);
int number1 = (randomNumber / 100) * 10;
int number2 = randomNumber % 10;
int result = number1 + number2;
System.Console.WriteLine(result);