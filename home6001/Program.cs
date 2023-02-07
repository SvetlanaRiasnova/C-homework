/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())
*/

Console.WriteLine(" Введите числа через запятую");

string nambers = Console.ReadLine();
int[] arr = Array.ConvertAll(nambers.Split(','), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) {
        count+=1;
    }
}

Console.WriteLine($"пользователь ввел {count} чисел больше 0");