/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

string numberChange(int number)
{
    string result = "";
    int temp = 0;
    for (int i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }
    return result;
}
string result = numberChange(41);
Console.WriteLine(result);