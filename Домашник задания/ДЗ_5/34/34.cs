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
        numbers[i] = new Random().Next(100, 1000);
    }

    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

void NumbersdividedBytwo(int[] array)
{   

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
        else
        {
            continue;
        }
    }
    System.Console.WriteLine(count);
}



int num = GetNumber("Write size of Array: ");
int[] arr = Array(num);
// PrintArray(arr);
NumbersdividedBytwo(arr);
