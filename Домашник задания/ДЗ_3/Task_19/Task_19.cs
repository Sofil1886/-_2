// ; Задача 19
// ; Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// ; 14212 -> нет
// ; 12821 -> да
// ; 23432 -> да

System.Console.WriteLine("Ввведите 5-значное число:");
int number = Convert.ToInt32(Console.ReadLine());
int lenNumber = number.ToString().Length;
int[] digits = new int[lenNumber];

if (lenNumber != 5)
{
    System.Console.WriteLine("Вы не ввели 5-значное число");
}
else
{
    for (int i = lenNumber - 1; i >= 0; i -= 1)
    {
        int digit = number % 10;
        digits[i] = digit;
        number /= 10;
    }

    int TrueCounter = 0;
    for (int num = 0; num < lenNumber; num += 1)
    {
        if (digits[num] == digits[lenNumber - 1 - num])
        {
            TrueCounter += 1;
        }
        else
        {
            break;
        }
    }

    if (TrueCounter == lenNumber)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }

}

System.Console.WriteLine();