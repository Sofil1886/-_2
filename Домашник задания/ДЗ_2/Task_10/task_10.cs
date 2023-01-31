System.Console.WriteLine("Введите трехзначное число:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int lenNumber = numberA.ToString().Length;

if (lenNumber != 3)
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int result = numberA / 10 % 10;

    System.Console.WriteLine(result);
}