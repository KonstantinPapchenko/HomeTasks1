﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); // Ввод числа

if (a > b)
    Console.Write("max " + a);
else
    Console.Write("max " + b);

