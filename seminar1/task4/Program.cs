﻿// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1 число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число:");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)    max = b;
if (max < c)    max = c;