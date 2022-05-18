/*Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 и выдает номер четверти плоскости, 
в которой нахрдится эта точка.
*/

int GetNumberOfQuater(int X, int Y)
{
    int result = 0;
    if (X > 0 && Y > 0)
    {
        result = 1;
    }
    else if (X < 0 && Y > 0)
    {
        result = 2;
    }
    else if (X < 0 && Y < 0)
    {
        result = 3;
    }
    else if (X > 0 && Y < 0)
    {
        result = 4;
    }
    return result;
}
void GimmeGod(int X, int Y)
{
    int quater = GetNumberOfQuater(X, Y);
    if (quater > 0)
    {
        Console.WriteLine($"Точка {X}:{Y} находится в {quater} четверти!");
    }
    else
    {
        Console.WriteLine($"Точка {X}:{Y} находится на пересечении четвертей!");
    }
}
GimmeGod(1,1);
GimmeGod(-1,1);
GimmeGod(-1,-1);
GimmeGod(1,-1);
GimmeGod(0,0);
GimmeGod(0,1);
GimmeGod(0,1);