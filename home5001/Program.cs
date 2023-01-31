/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
int [] CreateArray(int n) {
    int [] Array = new int[n];
    Random number = new Random();
        for (int i = 0; i < Array.Length; i++)
            {
            Array[i] = number.Next(100,1000);
            }
    return Array;
}

int n = GetNumber("введите размерность массива");
int[] newArr = CreateArray(n);

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]} ");
        }
    Console.WriteLine();
}
PrintArray(newArr);

int count = 0;
for (int j = 0; j < newArr.Length; j++){ 
        if (newArr[j]%2==0) {
            count+=1;
        }
}
Console.WriteLine($"в заданном массиве четных чисел {count}");




