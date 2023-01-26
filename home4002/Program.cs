/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
int result = 0;

while (true)
{
Console.WriteLine(message);

if (int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.WriteLine("Ввели не число. Повторите ввод");
}
}
return Math.Abs(result);
}

int GetSum(int number) {
    int sum = 0;
    string num = number.ToString();
    int length = num.Length;
    for (int i=0; i <= length; i++) {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}

int number = GetNumber("Введите любое число");
int result = GetSum(number);
Console.WriteLine(result);