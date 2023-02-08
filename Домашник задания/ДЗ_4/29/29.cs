// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetNumber("Write size of array:");
int B = GetNumber("Write first number:");
int C = GetNumber("Write last number:");

int [] GetArray(int size, int leftNumber, int rightNumber)
{
    int[] elements = new int[size];
    for (int i= 0; i < elements.Length; i++)
    {
        elements[i] = new Random().Next(leftNumber,rightNumber);
    }

    return elements;
}

int[] arr = GetArray(A, B, C);

System.Console.WriteLine($"[{string.Join(", ",arr)}]"); 
