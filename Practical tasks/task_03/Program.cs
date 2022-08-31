// 3. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,4}", matrix[i, j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReplaceMatrix(int[,] matrix)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}
Console.Clear();
int[,] matrix = CreateMatrix(5, 5, 0, 20);
PrintMatrix(matrix);
ReplaceMatrix(matrix);
PrintMatrix(matrix);
