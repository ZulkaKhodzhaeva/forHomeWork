﻿// Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, которая 
// принимает на вход целочисленное значение x и возвращает целую часть квадратного 
// корня от введенного числа.
// Нельзя использовать встроенные функции библиотеки Math!

int SqtrNumber(int num)
{
    num = num/2;
    return num;
}

int num1 = SqtrNumber(7);
Console.WriteLine(num1);