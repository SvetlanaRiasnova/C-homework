/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/
int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);
FindMinSumRow(numbers);


void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 50);
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

// метод поиска строки с наименьшей суммой 
void FindMinSumRow(int[,] array)
{
    int sumRow = 0;
    int minSum  = 0;
    int minSumNumberRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        {
            minSum += array[0, i];
        }
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];

            Console.WriteLine($"сумма {i + 1} строки равна {sumRow}");

            if (sumRow < minSum)
            {
                minSum = sumRow;
                minSumNumberRow = i;
            }
            sumRow = 0;
        }

    Console.WriteLine();
    Console.Write($"наименьшая сумма в строке {minSumNumberRow +1} ");
}