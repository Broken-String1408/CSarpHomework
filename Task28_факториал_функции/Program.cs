/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
Console.Clear();

int Method1(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}

System.Console.WriteLine("Введи число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
int result = Method1(numb1);
System.Console.WriteLine($"Произведение чисел от 1 до {numb1} = {result}");