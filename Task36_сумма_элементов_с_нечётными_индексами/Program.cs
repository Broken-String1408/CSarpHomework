/*
Напишите программу, которая находит сумму элементов с нечетными индексами 
в одномерном массиве целых чисел и выводит результат на экран.
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
int SumOddElements(int[] array)
{
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) odd = odd + array[i];
    }
    return odd;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
}
int[] userArray = GetRnd(10);
PrintArray(userArray);
System.Console.WriteLine();
int sumOdd = SumOddElements(userArray);
System.Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");