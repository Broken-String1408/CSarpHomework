/*
12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2)
{
    System.Console.WriteLine("yes, the first number is the square of the second number.");
}
else 
{
    System.Console.WriteLine(number1 % number2);
    System.Console.WriteLine("no, the first number is not the square of the second number.");
}