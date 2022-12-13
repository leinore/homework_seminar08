// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.



int[] numbers = new int[99 * 99 * 99];
int index = 0;


int[,,] FillMatrix(int x, int y, int z)
{

    int[,,] matrix = new int [x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i,j,k] = getRandom();
            }
        }
    }
    return matrix;
}

int getRandom() {
    bool isAlready;
    int rndNumber;

    do{
        rndNumber = new Random().Next(10,100);
        isAlready = false;        
        for(int i = 0; i < index; i++) {
            if(numbers[i] == rndNumber) {
                isAlready = true;
                break;
            }
        }
    } while (isAlready);

    numbers[index++] = rndNumber;
    return rndNumber;    
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}]=" + matrix[i,j,k] + " ");
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
