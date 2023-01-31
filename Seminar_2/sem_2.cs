
// Random rand = new Random();
// int number = rand.Next(100,1000);

// // System.Console.WriteLine(number);

// // int leftNumber = number/10;
// // int rightNumber = number%10;

// // System.Console.WriteLine($"{leftNumber}, {rightNumber}");


// System.Console.WriteLine(number);


// int leftNumber = number/ 100;           // Поиск первой цифры в трехзначном числе
// int rightNumber = number % 10;            // Поиск последней цифры в трехзначном числе

// int result = leftNumber*10+rightNumber;
// System.Console.WriteLine(result);




// System.Console.WriteLine("Введите два числа:");

// int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

// if (numberB % numberA == 0)
// {
//     System.Console.WriteLine("Кратно");
// }
// else if (numberB % numberA != 0)
// {
//     System.Console.WriteLine($"Не кратно, остаток {numberB % numberA}");
// }



// System.Console.WriteLine("Введите число:");
// int Number = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32


// if (Number % 7 == 0 & Number % 23 == 0)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }



System.Console.WriteLine("Введите число:");

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


