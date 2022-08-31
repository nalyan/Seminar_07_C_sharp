// 2. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int[,] matrix = CreateMatrix(3,4,0,10);
PrintMatrix(matrix);
Console.WriteLine("Средние арифметические столбцов: ");
for(int j=0; j<matrix.GetLength(1);  j++)
{
    double sum = 0;
    double rows = matrix.GetLength(0);
    for(int i=0; i<matrix.GetLength(0); i++)
        sum = sum + matrix[i,j];
    Console.Write(Math.Round(sum/rows, 2) + "\t");
}