// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



using System.Net;

int[,] GetArray(int row, int colum, int minValue, int maxValue)
{
    int[,] array = new int [row, colum];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine(" ");
    }
}


int[,] MatrixMulti(int[,] matrixA, int[,] matrixB)
    {       
        if(matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Умножение невозможно");
        }
        
        
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }   
        return matrixC;
    }


int[,] matrix = GetArray(2, 2, 1, 10);
PrintArray(matrix);
Console.WriteLine(" ");
int[,] array = GetArray(2, 2, 1, 10);
PrintArray(array);
Console.WriteLine(" ");
int[,] matrixC = MatrixMulti(matrix, array);
PrintArray(matrixC);

