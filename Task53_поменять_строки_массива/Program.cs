/* 53. Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/


 int[,] array = {{1,2,3,4}, {5,6,7,8}, {9,10,11,12}};

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    System.Console.WriteLine();
    
}

System.Console.WriteLine();

//  ArraySwapRows(array);

 SwapFirstAndLastRows(array);

 for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    System.Console.WriteLine();
    
}


void SwapFirstAndLastRows(int[,] matrix)
    {
        // Проверяем, что массив не пустой и содержит хотя бы две строки
        if (matrix.GetLength(0) >= 2) return;

         // Меняем местами первую и последнюю строки
            int numRows = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int temp = matrix[0, i];
                matrix[0, i] = matrix[numRows - 1, i];
                matrix[numRows - 1, i] = temp;
            }
    }

 void ArraySwapRows(int[,] arr)
 {
    int[] temp = new int[arr.GetLength(1)];

    int lastIndex = arr.GetLength(0) - 1;

    for(int i = 0; i < temp.Length; i++)
    {
        temp[i] = arr[0, i];
        arr[0, i] = arr[lastIndex, i];
    }

    for(int i = 0; i < temp.Length; i++)
    {
        arr[lastIndex, i] = temp[i];
    }
 } 

