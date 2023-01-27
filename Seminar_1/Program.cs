// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int result = number*number;
// Console.Write(result);



// Задача 1

System.Console.WriteLine("Введите два числа:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

if (numberB*numberB == numberA)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

// Задача 3

System.Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

if (day == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (day == 2)
{
    System.Console.WriteLine("Вторник");
}
if (day == 3)
{
    System.Console.WriteLine("Среда");
}

if (day == 4)
{
    System.Console.WriteLine("Четверг");
}

if (day == 5)
{
    System.Console.WriteLine("Пятница");
}

if (day == 6)
{
    System.Console.WriteLine("Суббота");
}
if (day == 7)
{
    System.Console.WriteLine("Воскресенье");
}

