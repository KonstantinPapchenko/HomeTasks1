/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); // Ввод числа
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine()); // ввод числа

if (a > b && a > c)
    Console.Write(a);
else if (b > a && b > c)
    Console.Write(b);
else
    Console.Write(c);