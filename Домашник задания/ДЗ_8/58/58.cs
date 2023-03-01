// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateMatrix(int row, int col)
{
    Random rand = new Random();
    int[,] matrix = new int[row, col];
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

int[,] ProdMatrix(int[,] firstmatrix, int[,] secondmatrix)
{

    if (firstmatrix.GetLength(1) != secondmatrix.GetLength(0))
    {
        return null;
    }
    else
    {
        int[,] newMatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
        for (int i = 0; i < firstmatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondmatrix.GetLength(1); j++)
            {
                for (int k = 0; k < firstmatrix.GetLength(1); k++)
                {
                    newMatrix[i, j] += firstmatrix[i, k] * secondmatrix[k, j];
                }
            }
        }
        return newMatrix;
    }


}


int rows = ReadInt("Write number of rows in matrix: ");
int cols = ReadInt("Write number of columns in matrix: ");

int rows2 = ReadInt("Write number of rows in matrix: ");
int cols2 = ReadInt("Write number of columns in matrix: ");

var myMatrix = GenerateMatrix(rows, cols);
var myMatrix1 = GenerateMatrix(rows2, cols2);
PrintMatrix(myMatrix);
System.Console.WriteLine("------");
PrintMatrix(myMatrix1);
System.Console.WriteLine("------");
var result = ProdMatrix(myMatrix, myMatrix1);
if (result == null)
{
    System.Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    PrintMatrix(result);
}


