/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

void printArray(int [] arrayToPrint)
{
    System.Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine("]");
}
int sumElementsOfArray(int[] arrayToCalculate, int multiply)
{
    int result = 0;
    for (int i = 0; i < arrayToCalculate.Length; i++)
    {
        if(arrayToCalculate[i] * multiply > 0)
        {
            result += arrayToCalculate[i];
        }
    }
    return result;
}

int[] randomArray = getRandomArray(12,9);
int positiveSumOfArray = sumElementsOfArray(randomArray,1);
int negativeSumOfArray = sumElementsOfArray(randomArray,-1);
printArray(randomArray);

System.Console.WriteLine($"Сумма положительных чилел = {positiveSumOfArray}, сумма отрицательных = {negativeSumOfArray}");