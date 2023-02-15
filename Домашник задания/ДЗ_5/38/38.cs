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
        numbers[i] = new Random().Next(0,10);
    }

    return numbers;
}

void findMax(int[] array, out int max, out int min)
{
    max = array[0];
    min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }

        
    }
}


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }


int num = GetNumber("Write size of Array: ");
int[] arr = Array(num);
findMax(arr, out int max, out int min);
// PrintArray(arr);
System.Console.Write($"max = {max} ");
System.Console.Write($"min = {min} ");
System.Console.Write($"sum = {max+min}");

