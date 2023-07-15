// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool ElementFromMatrix(int[,] matrix, int i, int j)
{
    if(i < matrix.GetLength(0) && j < matrix.GetLength(1))
    return true;
    else
    return false;
}

void PrintResalt(bool resalt, int[,] matrix, int i, int j)
{
    if(resalt == false)
    Console.WriteLine("Элемента с такими координатами в данном массиве не существует");
    else
    Console.WriteLine(matrix[i, j]);
}

int m = ReadInt("Введите число строк: ");
int n = ReadInt("Введите число столбцов: ");
int[,] matrix = FillMatrix(m, n, 0, 10);
PrintMatrix(matrix);
int i = ReadInt("Введите номер строки нужного вам элемента: ");
int j = ReadInt("Введите номер столбца нужного вам элемента: ");
bool resalt = ElementFromMatrix(matrix, i, j);
PrintResalt(resalt, matrix, i, j);