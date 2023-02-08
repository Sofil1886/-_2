// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetNumber("Write number:");
int B = GetNumber("Write number:");

void product(int X, int Y)
{
    int baseNumber = X;
    for (int i = 1; i < Y; i++)
    {
        X = X * baseNumber;
    }
    System.Console.WriteLine(X);
}

product(A, B);