// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    var rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = rnd.Next(min, max);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write("{0,4}", matrix[i,j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinColumns(int[,] matrix)
{
    int sum = 0;
    int min = 0;
    int indexMin = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            sum+= matrix[i,j];
        }
        if(i==0) min = sum;
        else if(sum<min)
        {
            min = sum;
            indexMin = i;
        }
    }
    return indexMin;
}

Console.Clear();
int[,] matrix = CreateMatrix(4,5,-10,10);
PrintMatrix(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов - {MinColumns(matrix)+1}");