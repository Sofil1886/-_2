// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



int M = GetNumber("Введите неотрицатльное число M: ");
int N = GetNumber("Введите неотрицатльное число N: ");

if ((M < 0) || (N < 0))
{
    System.Console.WriteLine("Вы ввели отрицательное число, введите неотрицательное!");
}


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}


System.Console.WriteLine(Akkerman(M, N));
