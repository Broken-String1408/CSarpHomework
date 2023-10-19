/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.
*/

int Reverse(int a)
{
    int revN = 0;
    for (int i = a; i > 0; i /= 10)
    {
        revN = revN * 10 + i % 10;
        //System.Console.WriteLine(revN);
    }
    return revN;
}

System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = Reverse(N);

// int revN = 0;
// for (int i = N; i > 0; i /= 10)
// {
//     revN = revN * 10 + i % 10;
//     //System.Console.WriteLine(revN);
// }
if (N == revN)
    System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");