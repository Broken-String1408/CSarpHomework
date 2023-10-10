/*
Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

a = 2; b = 2 -> Введенные числа равны 2

a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 < number2)
{
    System.Console.WriteLine($"Первое число `{number1}` меньше чем второе число `{number2}`");
}
else if(number2 < number1)
{
    System.Console.WriteLine($"Первое число {number1} больше чем второе число {number2}");
}
else if(number1 == number2)
{
    System.Console.WriteLine($"Введенные числа равны {number1}");
}