/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 6) {
    Console.WriteLine("это рабочий день");
}  else  if (num >= 6 && num <=7) {
    Console.WriteLine("это выходной день");
} else {
    Console.WriteLine("такого дня недели нет");
}
