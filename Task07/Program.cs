/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    System.Console.WriteLine("Error");
}
else
{
    number = (number % 10);
    System.Console.WriteLine("The last digit is " + number);
}