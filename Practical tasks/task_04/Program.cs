// 4. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for(int i=0; i<matrix.GetLength(1); i++)
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
            Console.Write("{0,4}", matrix[i,j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SortMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1)-1; j++)
        {
            for(int k=j+1; k<matrix.GetLength(1); k++)
            {
                int temp = matrix[i,j];
                if(matrix[i,j]<matrix[i,k])
                {
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
        }
    }
}
Console.Clear();
int[,] matrix = CreateMatrix(4,4,0,30);
PrintMatrix(matrix);
SortMatrix(matrix);
PrintMatrix(matrix);