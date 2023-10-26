/*
37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(100);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

int[] MultiplyNumbers(int[] arr)
{
    int[] multiplied = new int[arr.Length - arr.Length / 2];
    int temp = 0;
    for (int i = 0; i < arr.Length - arr.Length / 2; i++)
    {
        if(arr[i] == arr[arr.Length - i -1]) temp = arr[i];
        if(arr[i] != arr[arr.Length - i -1]) temp = arr[i] * arr[arr.Length - i -1];
        multiplied[i] = temp;
    }
    
    return multiplied;
}

int[] userArray = GetRnd(5);
PrintArray(userArray);
System.Console.WriteLine();
PrintArray(MultiplyNumbers(userArray));

