/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    System.Console.WriteLine("Today is Monday");
} 
if(number == 2)
{
    System.Console.WriteLine("Today is Tuesday");
} 
if(number == 3)
{
    System.Console.WriteLine("Today is Wednesday");
} 
if(number == 4)
{
    System.Console.WriteLine("Today is Thursday");
} 
if(number == 5)
{
    System.Console.WriteLine("Today is Friday");
} 
if(number == 6)
{
    System.Console.WriteLine("Today is Saturday");
} 
if(number == 7)
{
    System.Console.WriteLine("Today is Friday");
} 
if(number > 7 || number < 1)
{
    System.Console.WriteLine("Error");
} 