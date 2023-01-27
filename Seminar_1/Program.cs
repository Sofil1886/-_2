// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int result = number*number;
// Console.Write(result);



// Задача 1

System.Console.WriteLine("Введите числа:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

if ((numberA*numberA == numberB) || (numberB*numberB == numberA))
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}