// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using System.IO.Compression;

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

int[] SumEllRow(int[,]arr)
{
    int[] array = new int [4];
    int z = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
           int sum = 0;
         for (int j = 0; j < arr.GetLength(1); j++) 
             {
              sum += arr[i, j];
            }
             if(z<4) 
            {
                array[z] = sum;
                z++;
            }
            // Console.WriteLine(sum); для проверки (чтобы не высчитывать вручную)
    }
    return array;
}  


int MinSum(int[] arr)
{
    int minRow = arr[0];
    int minIndex = 0;
    for (int i = 0; i < 4; i++)
    {
        if(minRow>arr[i]) 
        {
        minRow = arr[i];
        minIndex = i;
        }
        else continue;
    }
    return minIndex+1;
}






int[,] matrix = GetArray(4, 4, 1, 100);
PrintArray(matrix);
Console.WriteLine(" ");
int[] array = SumEllRow(matrix);
Console.WriteLine($"Строка с наименьшей суммой = {MinSum(array)}");
