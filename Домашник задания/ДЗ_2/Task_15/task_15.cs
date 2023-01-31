System.Console.WriteLine("Введите цифру:");

int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

if (numberA > 7 || numberA < 1)
{
    System.Console.WriteLine("Такого дня недели не существует");
}
else if (numberA < 6)
{
    System.Console.WriteLine("Нет");

}
else 
{
    System.Console.WriteLine("Да");
}