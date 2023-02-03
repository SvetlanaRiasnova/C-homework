/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите любое число");
string num = Console.ReadLine();
char[] numbers = num.ToCharArray();

 if (numbers.Length > 2) {
     Console.WriteLine($"третья цифра {num[2]}");
   }
 else {
    Console.WriteLine("третьей цифры нет");
   
 }


