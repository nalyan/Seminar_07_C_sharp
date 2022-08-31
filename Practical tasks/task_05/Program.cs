// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    var rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLongLength(0); i++)
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
void ConvertMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
Console.Clear();
int[,] matrix = CreateMatrix(5, 5, 0, 30);
PrintMatrix(matrix);

if(matrix.GetLength(0) == matrix.GetLength(1))
{
    ConvertMatrix(matrix);
    PrintMatrix(matrix);
}
else Console.WriteLine("Невозможно преобразовать массив, т.к. матрица не квадратная");
