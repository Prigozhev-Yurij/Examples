Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdDigit = Convert.ToInt32(Console.ReadLine());
if (firstDigit == secondDigit)
{
    if (secondDigit == thirdDigit)
    {
        Console.Write("Числа равны");
    }
    else
    {
        if (secondDigit > thirdDigit)
        {
            Console.Write("Максимальное число " + secondDigit);
        }
        else
        {
            Console.Write("Максимальное число " + thirdDigit);
        }
    }
}
else
{
    if (firstDigit > secondDigit)
    {
        if (firstDigit > thirdDigit)
        {
            Console.Write("Максимальное число " + firstDigit);
        }
        else
        {
            Console.Write("Максимальное число " + thirdDigit);
        }
    }
    else
    {
        if (secondDigit > thirdDigit)
        {
            Console.Write("Максимальное число " + secondDigit);
        }
        else
        {
            Console.Write("Максимальное число " + thirdDigit);
        }
    }
}