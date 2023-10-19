/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
int Numbers1(int numb)
{
    int sum = 0;
    for (int i = 0; i <= numb; i++)
    {
        sum = sum + i;
    }
    return sum;
}
System.Console.WriteLine("Введи число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int resault = Numbers1(userNumber);
System.Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {resault}");