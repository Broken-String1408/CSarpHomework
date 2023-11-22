/*
57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

// int a = ConvertToInt32

System.Console.WriteLine("Введи размер: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] buffer = new int[size];

int[,] GetRandom2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, size);
        }
    }
    return array;
}

void Counter(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buffer[arr[i, j]] ++;
        }
    }
}

void PrintResult()
{
    for (int i = 0; i < buffer.Length; i++)
    {
        if(buffer[i] > 0) 
        {
            System.Console.WriteLine($" {i} встречается {buffer[i]} раз(а)");
        }
    }
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

int[,] array2D = GetRandom2DArray(5,5);
PrintArray(array2D);
System.Console.WriteLine();
Counter(array2D);
PrintResult();


