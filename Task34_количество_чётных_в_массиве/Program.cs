/*
Напишите программу, 
которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел 
и выводит результат на экран.
*/
int[] array ={100, 102, 105, 166, 283, 764, 300, 499, 133};

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + (i + 1 > array.Length - 1? "" : "\t"));
    }
    System.Console.WriteLine();

}
PrintArray(array);
System.Console.WriteLine();
int counter = EvenCount(array);
System.Console.WriteLine($"Колличество чётных элементов: {counter}");
