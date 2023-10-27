/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fibonacci(int number)
{
    int size = number;
    if (number < 2) size = 2;
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Number N = " + arrayOne.Length + ": ");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    System.Console.WriteLine();
}
int number = Prompt("Enter number: ");
PrintArray(Fibonacci(number));


















// void Fibonachi(int numb)
// {
//     int[] fibonachi = new int[numb + 1];
//     if (numb == 0) System.Console.WriteLine("1");
//     else
//     {
//         for (int i = 0; i < 2; i++)
//         {
//             fibonachi[i] = i;
//             System.Console.Write(fibonachi[i] + " ");
//         }
//         for (int i = 2; i < numb; i++)
//         {
//             fibonachi[i] = fibonachi[i - 2] + fibonachi[i - 1];
//             System.Console.Write(fibonachi[i] + " ");
//         }
//     }


// }

// Fibonachi(15);

// if(n == 1 || n == 0) System.Console.Write("0");

//     if(n >= 2)
//     {
//         System.Console.Write("0 1 ");

//         int first = 0;
//         int second = 1;
        
//         int third = first + second;

//         int count = 3;

//         while(count <= n)
//         {
//             third = first+second;
//             first = second;
//             second = third;
//             count++;

//             System.Console.Write(third + " ");
//         }
//     }