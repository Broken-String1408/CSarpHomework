/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}
if(number > 99)
{
    for(int i = number; i > 99; i/=10)
    {
        number = i;
    }
    System.Console.WriteLine($"Третья цифра {number % 10}");
}
else System.Console.WriteLine("Третьей цифры нет");


// Ниже приведены варианты иных возможных решений 

// if (number < 0)
// {
//     number = number * -1;
// }
// if (number < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// while (number > 999)
// {
//     number = number / 10;
// }
// if(number <= 999 & number >= 100)
//     {
//         number = number % 10;
//         System.Console.WriteLine($"Третья цифра это {number}");
//     }



// if (number < 0)
// {
//     number = number * -1;
// }
// if (number < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else
// {

//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     number = number % 10;
//     System.Console.WriteLine($"Третья цифра это {number}");
// }
