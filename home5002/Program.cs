/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int sum = 0;
for (int j = 0; j < newArr.Length; j++){ 
        if (newArr[j]%2!=0) {
            sum+=newArr[j];
        }
        
}
Console.WriteLine($"в заданном массиве сумма нечетных чисел {sum}");
