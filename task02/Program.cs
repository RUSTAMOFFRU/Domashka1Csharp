﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число для сравнения");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Первое число {num1} большее");
    Console.WriteLine($"Второе число {num2} меньшее");
}
else
{
    Console.WriteLine($"Второе число {num2} большее");
    Console.WriteLine($"Первое число {num1} меньшее");
}