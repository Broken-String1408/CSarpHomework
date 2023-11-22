/*
Реализуйте класс MatrixOperations, который содержит следующие статические методы:

MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу, которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

Если аргументы не переданы, программа использует матрицы по умолчанию. Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.

Аргументы, передаваемые в метод/функцию:

'1,2;3,4'
На выходе:


Исходная матрица:
1   2   
3   4   

Matrix B:
5   6   
7   8   

Multiplication result:
19  22  
43  50
*/
void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    int matrixARows = matrixA.GetLength(0);
    int matrixBCols = matrixB.GetLength(1);
    int matrixACols = matrixA.GetLength(1);
    int matrixBRows = matrixB.GetLength(0);
    if(matrixACols != matrixBRows)
    {
        System.Console.WriteLine("It is impossible to multiply.");
        return;
    }

    int[,] result = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix(result);
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {

            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                result[i, j] +=  matrixA[i, k] * matrixB[k, j];
            }

        }
    
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
       System.Console.WriteLine();
    }
    
}

int[,] matrixA = {{1,2}, {3,4}, {3,4}};
int[,] matrixB = {{5,6}, {7,8}};
MultiplyIfPossible(matrixA, matrixB);