/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.WriteLine("Введите число a");
string num1 = Console.ReadLine();

Console.WriteLine("Введите число b");
string num2 = Console.ReadLine();

int a = Convert.ToInt32(num1);
int b = Convert.ToInt32(num2);
if (a > b) {
    Console.WriteLine($"максимальное число {a}, минимальное {b}");
} else if (b > a) {
    Console.WriteLine($"максимальное число {b}, минимальное {a}");
} else {
    Console.WriteLine($"числа равны");
}