// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void Find_Length_between_points(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt((Math.Pow((by - ay), 2) + Math.Pow((bx - ax), 2) + Math.Pow((bz - az), 2)));
    System.Console.WriteLine(result);
}





int AX = InputNumber("Введите координату X1: ");
int AY = InputNumber("Введите координату Y1: ");
int AZ = InputNumber("Введите координату Z1: ");
int BX = InputNumber("Введите координату X2: ");
int BY = InputNumber("Введите координату Y2: ");
int BZ = InputNumber("Введите координату Z2: ");

Find_Length_between_points(AX, AY, AZ, BX, BY, BZ);