/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int DegreeNum(int a, int b) {
        int res = Convert.ToInt32(Math.Pow(a, b));
        return res;
    }

int a = GetNumber("Введите число a");
int b = GetNumber("Введите число b");

int result = DegreeNum(a, b);
Console.WriteLine(result);