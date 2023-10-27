/*
51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/
int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    } 
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int FindSum(int[,] arr1)
{
    int sum = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if(i == j) sum = sum + arr1[i,j];
        }
    }
    return sum;
}

// int SumOfDiagonal(int [,] array)
// {
//     int result = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         result += array[i,i];        
//     }

//     return result;
// }

int[,] u2DArray = Get2DArray(4,4);
Print2DArray(u2DArray);
System.Console.WriteLine();
System.Console.WriteLine(FindSum(u2DArray));
// int summ = FindSum(u2DArray);
// System.Console.WriteLine($"Сумма чисел по главной диагонали = {summ}"); 