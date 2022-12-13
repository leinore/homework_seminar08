// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите число строк первой матрицы:");
Console.WriteLine("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы (и строк второй матрицы):");
Console.WriteLine("n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы:");
Console.WriteLine("p: ");
int p = Convert.ToInt32(Console.ReadLine());

int [,] matrixFirst = FillMatrix(m,n);
int [,] matrixSecond = FillMatrix(n,p);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixFirst);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixSecond);
Console.WriteLine();

int[,] matrixResult = new int[m,p];

void MultiplyMatrix(int[,] matrixFirst, int[,] matrixSecond, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrixFirst.GetLength(1); k++)
        {
        sum += matrixFirst[i,k] * matrixSecond[k,j];
        }
        matrixResult[i,j] = sum;
    }
    }
}

MultiplyMatrix(matrixFirst, matrixSecond, matrixResult);
Console.WriteLine("Произведение первой и второй матрицы:");
PrintMatrix(matrixResult);
Console.WriteLine();