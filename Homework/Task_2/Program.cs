Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
if (firstDigit == secondDigit)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (secondDigit > firstDigit)
    {
        Console.WriteLine("Большее число " + secondDigit);
        Console.WriteLine("Меньшее число " + firstDigit);
    }
    else
    {
        Console.WriteLine("Большее число " + firstDigit);
        Console.WriteLine("Меньшее число " + secondDigit);
    }
}

