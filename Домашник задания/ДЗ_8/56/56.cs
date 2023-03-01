// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void WriterowWithlessSum(int[,] matrix)
{
    int[] numbers = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        numbers[i] = sum;
    }

    int max = numbers[0];
    for (int element = 0; element < numbers.Length; element++)
    {
        if (numbers[element] > max)
        {
            max = numbers[element];
        }
    }
    int res = Array.IndexOf(numbers, max);
    System.Console.WriteLine($"{res+1} строка");
}


int rows = ReadInt("Write number of rows in matrix: ");
int cols = ReadInt("Write number of columns in matrix: ");

var myMatrix = GenerateMatrix(rows, cols);

PrintMatrix(myMatrix);
System.Console.WriteLine("-------");
WriterowWithlessSum(myMatrix);