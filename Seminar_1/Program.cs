// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int result = number*number;
// Console.Write(result);



// Задача 1

// System.Console.WriteLine("Введите два числа:");

// int numberA = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int numberB = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

// if (numberB*numberB == numberA)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

// Задача 3

// System.Console.WriteLine("Введите число:");
// int day = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

// switch (day)
// {
//     case 1:
//         System.Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         System.Console.WriteLine("Вторник");
//         break;
//     case 3:
//         System.Console.WriteLine("Среда");
//         break;
//     case 4:
//         System.Console.WriteLine("Четверг");
//         break;
//     case 5:
//         System.Console.WriteLine("Пятница");
//         break;

//     case 6:
//         System.Console.WriteLine("Суббота");
//         break;

//     case 7:
//         System.Console.WriteLine("Воскресенье");
//         break;
//     default:
//         System.Console.WriteLine("Такого дня недели не существует");
//         break;
// }

// if (day == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if (day == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if (day == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if (day == 4)
// {
//     System.Console.WriteLine("Четверг");
// }

// else if (day == 5)
// {
//     System.Console.WriteLine("Пятница");
// }

// else if (day == 6)
// {
//     System.Console.WriteLine("Суббота");
// }
// else if (day == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }
// else 
// {
//     System.Console.WriteLine("Такого дня недели не существует")
// }

// Задача 5

// System.Console.WriteLine("Введите число:");

// int N = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
// int start = -N;

// // while (start <= N)
// // {
// //    System.Console.Write(start + " ");
// //    start += 1;
// // }

// for (int i = - N; i <= N; i+=1)
// {
//     System.Console.Write(i+ " ");
// }


// Задача 7

System.Console.WriteLine("Введите число:");

int N = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32
System.Console.Write(N%2);