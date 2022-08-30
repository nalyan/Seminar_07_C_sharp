// 1. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreatMatrix(int rows, int columns, int min, int max)
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
            Console.Write("{0,4}", matrix[i,j]);
        Console.WriteLine();
    }   
    Console.WriteLine(); 
}

void NumberPosition(int number, int[,] matrix)
{
    bool check = false;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == number)
            {
                Console.WriteLine($"позиция числа {number}: ({i}, {j})");
                check = true;
            }
        }
    }
    if(check == false) Console.WriteLine($"Такого элемента в массиве нет");
}

Console.Clear();
int[,] matrix = CreatMatrix(4,4,-10,10);
PrintMatrix(matrix);
int number = InputNumber("Введите число: ");
NumberPosition(number, matrix);
