/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int GetNumberA(string message)
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
return result;
}

int GetNumberB(string message)
{
int result = 0;

while (true)
{
Console.WriteLine(message);

if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
{
break;
}
else
{
Console.WriteLine("Ввели не число или число не натуральное. Повторите ввод");
}
}
return result;
}

int DegreeNum(int a, int b) {
        int res = Convert.ToInt32(Math.Pow(a, b));
        return res;
    }

int a = GetNumberA("Введите число a");
int b = GetNumberB("Введите число b");

int result = DegreeNum(a, b);
Console.WriteLine(result);