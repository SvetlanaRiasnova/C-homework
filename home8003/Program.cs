/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstArr = new int[m, n];
int[,] secondArr = new int[m, n];
int[,] resultArr = new int[m, n];

FillArray(firstArr);
PrintArray(firstArr);
Console.WriteLine();

FillArray(secondArr);
PrintArray(secondArr);
Console.WriteLine();

MultArr(firstArr, secondArr);

void MultArr(int[,] array, int[,] array2) {

    if (array.GetLength(0) != array2.GetLength(1)) {
        Console.WriteLine("матрицы не cогласованы, произведение не выполнимо");
                Console.WriteLine();
        return;
    } else {
    
    for (int i = 0; i < array.GetLength(0); i++)
       {
            for (int j = 0; j < array2.GetLength(1); j++) 
                {
                    resultArr[i,j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                        {
                            resultArr[i, j] += array[i, k] * array2[k, j];
                        }
                }
        }
    Console.WriteLine("результат перемножения матриц :");
    PrintArray(resultArr);
    }
}

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