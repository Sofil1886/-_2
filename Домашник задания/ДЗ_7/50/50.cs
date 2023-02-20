int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void CheckNumber(int[,] matrix, int row, int col)
{
    
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > col)
    {
        System.Console.WriteLine(matrix[row, col]);
    }
    else
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
}

int rows = ReadInt("Write number of rows in matrix: ");
int cols = ReadInt("Write number of columns in matrix: ");

int coordinate_1 = ReadInt("Write coordinate_1 in matrix: ");
int coordinate_2 = ReadInt("Write coordinate_2 in matrix: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

CheckNumber(myMatrix, coordinate_1, coordinate_2);