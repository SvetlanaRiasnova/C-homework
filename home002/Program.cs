/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число a");
string num1 = Console.ReadLine();

Console.WriteLine("Введите число b");
string num2 = Console.ReadLine();

Console.WriteLine("Введите число c");
string num3 = Console.ReadLine();

int a = Convert.ToInt32(num1);
int b = Convert.ToInt32(num2);
int c = Convert.ToInt32(num3);

int max = a;
if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }
                      
            Console.WriteLine($"Наибольшее из введённых чисел -> {max}");