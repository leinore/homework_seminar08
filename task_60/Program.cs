// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i,j,k] + " ");
                Console.Write(matrix[i,j,k] + " ");
            }
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c:");
int c = Convert.ToInt32(Console.ReadLine());

int [,,] matrix = FillMatrix(a,b,c);
PrintMatrix(matrix);
Console.WriteLine();
