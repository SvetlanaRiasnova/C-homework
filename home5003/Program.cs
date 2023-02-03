/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
 минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int GetNumber(string message) {
    int result = 0;
        while (true)
        {
            Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out result) && result > 1){
                        break;
                    }
                else {
                    Console.WriteLine("Ввели не число. Повторите ввод");
                  }
        }
    return result;
}
double[] CreateArray(int n) {
    double[] Array = new double[n];
    Random number = new Random();
        for (int i = 0; i < Array.Length; i++)
            {
            Array[i] = number.Next(-100, 100) + Math.Round(number.NextDouble(), 2);
            }
    return Array;
}

int n = GetNumber("введите размерность массива");
double[] newArr = CreateArray(n);

void PrintArray(double[] array) {
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]} ");
        }
    Console.WriteLine();
}
PrintArray(newArr);

double max = newArr[0];
double min = newArr[0];
double sum = 0;
for (int j = 0; j < newArr.Length; j++){ 
        if (newArr[j] > max) {
            max = newArr[j];
        } else if (newArr[j]< min){
            min = newArr[j];
        }
        sum = max - min;
}
Console.WriteLine($"максимальное число {max}");
Console.WriteLine($"минимальное число {min}");
Console.WriteLine($"в заданном массиве разница между максимальным и минимальным числом равна {sum}");
