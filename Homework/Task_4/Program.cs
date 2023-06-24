Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdDigit = Convert.ToInt32(Console.ReadLine());
if (firstDigit == secondDigit)
{
    if (secondDigit == thirdDigit)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        if (secondDigit > thirdDigit)
        {
            Console.WriteLine("Максимальное число " + secondDigit);
        }
        else
        {
            Console.WriteLine("Максимальное число " + thirdDigit);
        }
    }
}
else
{
    if (firstDigit > secondDigit)
    {
        if (firstDigit > thirdDigit)
        {
            Console.WriteLine("Максимальное число " + firstDigit);
        }
        else
        {
            Console.WriteLine("Максимальное число " + thirdDigit);
        }
    }
    else
    {
        if (secondDigit > thirdDigit)
        {
            Console.WriteLine("Максимальное число " + secondDigit);
        }
        else
        {
            Console.WriteLine("Максимальное число " + thirdDigit);
        }
    }
}