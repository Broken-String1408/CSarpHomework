/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Thread.Sleep(100);
        System.Console.Write(arr[i]);
        if (i < arr.Length -1) // [5, 7, 1, 4]
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor();
}
int[] ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}
int[] arr = GetArray(10);
PrintArray(arr);
int[] arr2 = ChangeArray(arr);
System.Console.WriteLine();
PrintArray(arr2);