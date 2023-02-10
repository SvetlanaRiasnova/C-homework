﻿/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

Console.WriteLine("Введите индекс строки искомого элемента");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца искомого элемента");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);

if (m < numbers.GetLength(0) && n < numbers.GetLength(1)) 
    Console.WriteLine($"заданному эементу соответствует число {numbers[m, n]}");
else 
    Console.WriteLine("такого элемента в массиве нет");

void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

