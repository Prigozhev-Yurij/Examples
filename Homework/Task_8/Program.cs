Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.Write("Введенное число = 1, четных чисел в промежутке нет");
}
else
{
    int count = 1;
    if (num > 1)
    {
        while (count <= num)
        {
            if (count % 2 == 0)
            {
                Console.Write(count + " ");
            }
            count++;
        }
    }
    else
    {
        while (count >= num)
        {
            if (count % 2 == 0)
            {
                Console.Write(count + " ");
            }
            count--;
        }
    }
}