double GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double a = GetNumber("Введите b1:");
double b = GetNumber("Введите k1:");
double c = GetNumber("Введите b2:");
double d = GetNumber("Введите k2:");

void FindCoordinates(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = k1 * X + b1;
    
    System.Console.WriteLine($"({X},{Y})");
}

FindCoordinates(a, b, c, d);