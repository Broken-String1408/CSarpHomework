/*
Напишите программу для работы с массивом вещественных чисел.

Реализуйте класс ArrayOperations, который содержит следующие статические методы:

FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.

FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.

CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.

PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
*/
double[] array ={3.17, 8.94, 2.36, 5.72, 0.85};

double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double min = array[0];
    double max = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}\t");
    }
    System.Console.WriteLine();
}
PrintArray(array);
double diff = CalcDifferenceBetweenMaxMin(array);
System.Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");