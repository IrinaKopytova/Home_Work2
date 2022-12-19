﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a < 1000 && a > 99 )
{
    int a2 = a % 100 / 10;
    Console.Write("Вторая цифра: "+ a2);
}
else if ( a > 999 || 100 > a )
{
    Console.Write("Введено не трехзначное число!");
}