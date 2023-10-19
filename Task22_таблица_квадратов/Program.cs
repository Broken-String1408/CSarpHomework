/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.



5 -> 1, 4, 9, 16, 25.

2 -> 1,4
*/
Console.Clear();

void TableSquares(int a)
{
    for (int i = 1; i <= a; i++)

    {
        System.Console.Write(i * i + " ");
    }
}
int userNumber = Convert.ToInt32(Console.ReadLine());
TableSquares(userNumber);
    // System.Console.Write("Введите число: ");

    // int numb = int.Parse(Console.ReadLine());



    // for (int i = 1; i <= numb; i++)

    // {

    //     System.Console.Write(i * i + " ");

    //     if (i % 3 == 0)

    //         System.Console.WriteLine();

    // }