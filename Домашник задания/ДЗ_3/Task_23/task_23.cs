// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int N = InputNumber("Введите число: ");

void find_res(int number)
{

    if (number < 1)
    {
        System.Console.WriteLine("Введите число, которое больше, либо равно 1");
    }
    else
    {
        for (int count = 1; count <= N; count += 1)
        {
            System.Console.Write(Math.Pow(count, 3) + ", ");
        }
    }

}


find_res(N);