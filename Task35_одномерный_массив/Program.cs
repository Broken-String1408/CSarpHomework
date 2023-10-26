/*
35. Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int[] GetArray(int size = 123)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 500 + 1);
    }
    return array;
}
// void PrintArray(int[] arr)
// {
//     Console.ForegroundColor = ConsoleColor.Cyan;
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Thread.Sleep(100);
//         System.Console.Write(arr[i]);
//         if (i < arr.Length -1) // [5, 7, 1, 4]
//         System.Console.Write(", ");
//     }
//     System.Console.Write("]");
//     Console.ResetColor();
// }
void FindNumber(int[] arr1)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.Write("[");
    int counter = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        Thread.Sleep(100);
        System.Console.Write(arr1[i]);
        if (i < arr1.Length -1) // [5, 7, 1, 4]
        {
            System.Console.Write(", ");    
        } 
        if (arr1[i] >= 10 & arr1[i] <= 99)
        {
            counter++;
        }
    }
    System.Console.Write($"] --> {counter}");
    Console.ResetColor();
}
int[] userArray = GetArray();
// PrintArray(userArray);
// System.Console.WriteLine();
FindNumber(userArray);