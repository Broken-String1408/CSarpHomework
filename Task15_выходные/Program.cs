/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
System.Console.WriteLine("Введи день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    System.Console.WriteLine("Нет, сегодня понедельник");
} 
if(number == 2)
{
    System.Console.WriteLine("Нет, сегодня вторник");
} 
if(number == 3)
{
    System.Console.WriteLine("Нет, сегодня среда");
} 
if(number == 4)
{
    System.Console.WriteLine("Нет, сегодня четверг");
} 
if(number == 5)
{
    System.Console.WriteLine("Нет, но уже пятница");
} 
if(number == 6)
{
    System.Console.WriteLine("Да, сегодня суббота");
} 
if(number == 7)
{
    System.Console.WriteLine("Да, сегодня воскресенье");
} 
if(number > 7 || number < 1)
{
    System.Console.WriteLine("Нет такого дня недели");
} 