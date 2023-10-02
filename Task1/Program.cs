// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


 int[,] SelectionSort(int[,] array)
{
    
   for (int i = 0; i < array.GetLength(0); i++) 
   {   
   for (int k = 0; k < array.GetLength(1); k++)
   {
        for (int j = 0; j < array.GetLength(1)-1; j++) 
        {
            
            if(array[i,j]<array[i,j+1]) 
            {
            int temp = array[i,j];
            array[i,j] = array[i,j+1];
            array[i,j+1] = temp;
            }
             
        }
   }
   
   }
    return array;
   }
   
int[,] matrix = GetArray(4, 3, 1, 10);
PrintArray(matrix);
Console.WriteLine(" ");
int[,] newMatrix = SelectionSort(matrix);
PrintArray(newMatrix);
