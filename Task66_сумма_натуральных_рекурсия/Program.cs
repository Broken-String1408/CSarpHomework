/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.WriteLine("Введи число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void SumRangeNumbers(int start, int end, int sum = 0)
{
    if (start > end)
    {
        System.Console.WriteLine($"Сумма от {m} до {n} -> {sum}");
        return;
    }
    sum += start;
    SumRangeNumbers(start + 1, end, sum);
}

void VerifyInput()
{
    if (m > n || m < 0 || n < 0)
    {
        System.Console.WriteLine("Введены неверные значения!");
        return;
    }
    SumRangeNumbers(m, n);
}

VerifyInput();


