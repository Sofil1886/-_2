
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetSumElements(int A)
{
    int result = 1;
    for (int i = 1; i <= A; i++)
    {
        result *= i;
    }
    return result;
}
// int num = GetNumber("Write number A: ");
// System.Console.WriteLine(num.Length);
// // System.Console.WriteLine($"Sum of numbers till {num} = {GetSumElements(num)}");



// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// string GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Console.ReadLine();
// }
// string num = GetNumber("Write number A: ");
// System.Console.WriteLine(num.Length);


// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int num = GetNumber("Write number A: ");
// System.Console.WriteLine($"Sum of numbers till {num} = {GetSumElements(num)}");



// Решение в группах задач:
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] Array(int A)
{
    int[] numbers = new int[A];
    
    for (int i =0; i < A; i++)
    {
        numbers[i] = new Random().Next(0,2);
    }
    
    return numbers;
}

void PrintArray(int [] array)
{
    for (int i =0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int num = GetNumber("Write number A: ");
int[] arr = Array(num);
PrintArray(arr);

