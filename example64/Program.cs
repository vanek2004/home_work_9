﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое, положительное число -->");
int numberB = Convert.ToInt32(Console.ReadLine());

NaturalNumber(numberB);

void NaturalNumber(int numB)
{
    if(numB == 0) return;
    Console.Write($"{numB} ");
    NaturalNumber(numB - 1);
}