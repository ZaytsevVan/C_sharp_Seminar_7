// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
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

double ArithmeticMeanOfOneColumn(int[,] matrix, int j)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    double arith = Convert.ToDouble(sum) / matrix.GetLength(0);
    arith = Math.Round(arith, 1);
    return arith;
}

double[] ArithmeticMeanOfColumns(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {   
        array[j] = ArithmeticMeanOfOneColumn(matrix, j);
    }
    return array;
}

void PrintArray(double[] arrayForPrint)
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int m = ReadInt("Введите число строк: ");
int n = ReadInt("Введите число столбцов: ");
int[,] matrix = FillMatrix(m, n, 0, 10);
PrintMatrix(matrix);
double[] arith = ArithmeticMeanOfColumns(matrix);
PrintArray(arith);