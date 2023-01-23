/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

//метод нахождения второй цифры трехзначного числа
int FindSecondNumber(int number) {
    int firstNumDel = number % 100;
    int secondNum = firstNumDel / 10;

 return secondNum;
}

int findNum = FindSecondNumber(number);
Console.WriteLine($"второе число равно {findNum}");