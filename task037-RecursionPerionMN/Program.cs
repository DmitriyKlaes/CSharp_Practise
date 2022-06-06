/*
Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void NaturalNumbersMN(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber + 1)
    {
        return;
    }
    else
    {
        Console.Write(firstNumber);
        if (firstNumber < secondNumber)
        {
            Console.Write(", ");
        }
        NaturalNumbersMN(firstNumber + 1, secondNumber);

    }
}
NaturalNumbersMN(4, 8);