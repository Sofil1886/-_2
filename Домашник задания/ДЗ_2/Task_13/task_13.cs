﻿System.Console.WriteLine("Введите число:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int lenNumber = numberA.ToString().Length;

if (lenNumber < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    int multiplier = lenNumber - 3;

    int result = numberA / (Convert.ToInt32(Math.Pow(10, multiplier))) % 10;

    System.Console.WriteLine(result);
}