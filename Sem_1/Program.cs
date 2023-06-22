//Напишите программу, которая на вход принимает 
// число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// using System.ComponentModel;
// Console.Write("Введите число: ");
// double number = Convert.ToDouble(Console.ReadLine());
// double result = number * number;

// Console.WriteLine("Квадрат числа " + number + " равен: " + result);


// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// if (firstDigit == secondDigit * secondDigit)
// {
//     Console.WriteLine("Число " + firstDigit + " является квадратом от числа " + secondDigit);
// }
// else
// {
//     Console.WriteLine("Число " + firstDigit + " не является квадратом от числа " + secondDigit);
// }

// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int numder = Convert.ToInt32(Console.ReadLine());
int negative = numder * (-1);
if (numder > 0)
{
    while (negative <= numder)
    {   
        Console.WriteLine(negative);
        negative ++;
    }
}
else
{
    while (negative >= numder)
    {
        Console.WriteLine(negative);
        negative --;
    }
}
