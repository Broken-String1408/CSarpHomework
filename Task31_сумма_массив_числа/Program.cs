/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void SumArray(int[] arr1)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPos = sumPos + arr[i];
        if (arr[i] < 0) sumNeg = sumNeg + arr[i];
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine($"Сумма положительных чисел равна {sumPos}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    System.Console.WriteLine($"Cумма отрицательных равна {sumNeg}");
    Console.ResetColor();
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Thread.Sleep(450);
        System.Console.Write(arr[i]);
        if (i < arr.Length -1) // [5, 7, 1, 4]
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor();
}

int[] userArray = GetArray(12);
PrintArray(userArray);
System.Console.WriteLine();
SumArray(userArray);