/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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

void NaturalNumbers (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NaturalNumbers (number - 1);
}

int number = GetNumber("Введите целое число N");
NaturalNumbers(number);