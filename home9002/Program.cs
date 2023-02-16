/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message) {
    int result = 0;
        while (true)
        {
            Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out result) && result >= 1){
                        break;
                    }
                else {
                    Console.WriteLine("Ввели не число. Повторите ввод");
                  }
        }
    return result;
}

void GapNumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    GapNumberSum(m, n, sum);
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

GapNumberSum(m, n, 0);

