/*
Задача 70: Напишите программу, 
которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 
*/

void SummPairElements(int firstNumber, int secondNumber, int count)
{
    if (count == 0)
    {
        return;
    }
    Console.Write($"{firstNumber} ");
    SummPairElements(secondNumber, firstNumber + secondNumber, count - 1);
}
SummPairElements(3,4,5);