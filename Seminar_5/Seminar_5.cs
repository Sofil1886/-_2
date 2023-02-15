// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-5, 5);
    }

    return numbers;
}


// void PrintandChangeArray(int [] array)
// {
//     for (int i =0; i < array.Length; i++)
//     {
//             array[i] *= -1;
//             System.Console.Write($"{array[i]} ");
//     }
// }

// int num = GetNumber("Write size of Array: ");
// int[] arr = Array(num);
// PrintandChangeArray(arr);



void CheckNumber(int[] array, int a)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            count += 1;
        }
        else
        {
            continue;
        }
    }
    System.Console.WriteLine(count);
    if (count > 0)
    {
        System.Console.Write("Yes");
    }
    else
    {
        System.Console.Write("No");
    }

}


void PrintArray(int [] array)
{
    for (int i =0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int num = GetNumber("Write size of Array: ");
int ourNumber = GetNumber("Write our number: ");
int[] arr = Array(num);

PrintArray(arr);
CheckNumber(arr, ourNumber);