/*Задача 29: Напишите программу, которая задаёт массив из 8(????) элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int GetNumber(string message)
{
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

int [] CreateArray(int n)
{
int [] Array = new int[n];
Random number = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = number.Next(0,100);
}
return Array;
}

int n = GetNumber("Введите длину массива");
int [] a = CreateArray(n);

void PrintArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($" {array[i]} ");
}
}
PrintArray(a);



