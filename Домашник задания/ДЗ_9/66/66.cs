// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}




void FindSum(int m, int n, int sum = 0)
{
    if (m <= n)
    {   
        sum += m; 
        FindSum(m+1, n, sum);      
    }
    else
    {
        System.Console.WriteLine(sum);
    }
    
}


int M = GetNumber("Write number M: ");
int N = GetNumber("Write number N: ");
FindSum(M, N);