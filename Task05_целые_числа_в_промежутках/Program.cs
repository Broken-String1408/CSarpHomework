﻿/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
/*
int N = -number;
while(N <= number) 
{
    System.Console.Write(N + " " );
    N = N + 1;
}
*/


for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}