/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/


System.Console.WriteLine("Введи трёхзначное чило");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 999 || number < 100 )
{
    System.Console.WriteLine("По нормальному ж попросили, ТРЁХЗНАЧНОЕ. Пробуй ещё раз.");
}
else
{
    number = (number / 10) % 10;
    System.Console.WriteLine(number);
}


// Я сделал 2 варианта решения этой задачи. Можно использовать оба варианта

// int number = new Random().Next(100, 1000);
// System.Console.WriteLine("Выпал рандом: " + number);
// int number1 = (number / 10) % 10;
// System.Console.WriteLine($"Число {number} и его середина {number1}");