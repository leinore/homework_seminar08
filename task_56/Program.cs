// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

again:
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if(m == n) {
    Console.WriteLine("Ошибка. Введите прямоугольный массив.");
    goto again;
}

int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

int SumElements(int[,] matrix, int i)
{
    int sum = matrix[i,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
    sum += matrix[i,j];
    }
    return sum;
}

int minSum = 0;
int sum = SumElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSum = SumElements(matrix, i);
    if (sum > tempSum)
    {
    sum = tempSum;
    minSum = i;
    }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой ({sum}) элементов ");