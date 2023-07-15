// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] tempMatrix = new double[row, col];
    Random rand = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(double[,] matrixForPrint)
{
    for(int i = 0; i < matrixForPrint.GetLongLength(0); i++)
    {
        for(int j = 0; j < matrixForPrint.GetLongLength(1); j++)
        {
            Console.Write(matrixForPrint[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int m = ReadInt("Введите число строк: ");
int n = ReadInt("Введите число столбцов: ");
double[,] matrix = FillMatrix(m, n, 0, 10);
PrintMatrix(matrix);