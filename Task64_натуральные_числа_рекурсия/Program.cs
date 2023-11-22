/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
System.Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
void AllNatural(int n)
{
    if(n == 0) return;
    string suf = "";
    if(n != 1) suf = ", ";
    System.Console.Write(n + suf); 
    AllNatural(n - 1);
    
}

AllNatural(number);