/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/


int[,] array2D = GetRandom2DArray(new Random().Next(3,5), new Random().Next(3,5));
PrintArray(array2D);
System.Console.WriteLine();
int[,] swapArray = ArraySwapRowsCol(array2D);
if(swapArray == null) System.Console.WriteLine("Rows and colls have different size");
else
PrintArray(swapArray);

int[,] GetRandom2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int [,]? ArraySwapRowsCol(int[,] arr)
{
    int rowSize = arr.GetLength(0);
    int colSize = arr.GetLength(1);
//    if (rowSize != colSize) return null;
    int[,] result = new int[colSize, rowSize];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
        {
            result[j, i] = arr[i, j];
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write(arr[i, j] + "\t");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}