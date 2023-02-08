// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}
string num = GetNumber("Write number: ");

void SumResult(string number)
{   
    int result = 0;
    for(int i =0; i < number.Length; i ++)
    {
        int convertednumber = Convert.ToInt32(number[i].ToString());
        result = result + convertednumber;
    }
    System.Console.WriteLine(result);
}

SumResult(num);

