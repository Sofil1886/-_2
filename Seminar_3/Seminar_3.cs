// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



// void Find_Length_between_points(int ax, int by)
// {
//     if (a == 1)
//     {
//         System.Console.WriteLine("x > 0, y > 0");
//     }
//     else if (a == 2)
//     {
//         System.Console.WriteLine("x < 0, y > 0");
//     }
//     else if (a == 4)
//     {
//         System.Console.WriteLine("x > 0, y < 0");
//     }
//     else if (a == 3)
//     {
//         System.Console.WriteLine("x < 0, y < 0");
//     }
//     else
//     {
//         System.Console.WriteLine("Нет такой четверти");
//     }
// }


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

// void Find_Length_between_points(int ax, int ay, int bx, int by)
// {
//     double result = Math.Sqrt((Math.Pow((by - ay), 2) + Math.Pow((bx - ax), 2)));
//     System.Console.WriteLine(result);
// }


int N = InputNumber("Введите число: ");
void find_res(int number)
{

    if (number < 1)
    {
        System.Console.WriteLine("Введите число, которое больше 1");
    }
    else
    {
        int count = 1;
        while (count <= number)
        {
            System.Console.Write(Math.Pow(count, 2) + ", ");
            count++;
        }
    }

    // for(int count = 1; count <= N; count += 1)
    // {
    //     System.Console.Write(Math.Pow(count, 2) + ", ");
    // }
}
    find_res(N);
