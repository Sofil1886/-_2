int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



double[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    double[,] matrix = new double [rows, cols];
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Write number of rows in matrix: ");
int cols = ReadInt("Write number of columns in matrix: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);