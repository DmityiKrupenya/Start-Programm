﻿// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    if (N > 0) 
    {
        Console.WriteLine(i * i * i);
    }    
    else 
    {
        Console.WriteLine("Введите положительное число");
    }    
}
