Console.WriteLine(" 1. Сложить 2 числа");
Console.WriteLine(" 2. Вычесть первое из второго");
Console.WriteLine(" 3. Перемножить 2 числа");
Console.WriteLine(" 4. Разделить первое на второе");
Console.WriteLine(" 5. Возвести в степень N первое число");
Console.WriteLine(" 6. Найти квадратный корень из числа");
Console.WriteLine(" 7. Найти 1 процент от числа");
Console.WriteLine(" 8. Найти факториал из числа");
Console.WriteLine(" 9. Выйти из программы");
Console.WriteLine("Выберите операцию: ");
int i = 0;
while (i <= 8)
{
    int count = Convert.ToInt32(Console.ReadLine());
    i = count;
    if (count == 1)
    {
        Console.WriteLine("введите первое число: ");
        int pervoe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число: ");
        int vtoroe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(pervoe + vtoroe);
        Console.WriteLine("введите число еще раз: ");


    }
    if (count == 2)
    {
        Console.WriteLine("введите первое число: ");
        int pervoe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число: ");
        int vtoroe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(vtoroe - pervoe);
        Console.WriteLine("введите число еще раз");
    }
    if (count == 3)
    {
        Console.WriteLine("введите первое число: ");
        int pervoe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число: ");
        int vtoroe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(pervoe * vtoroe);
        Console.WriteLine("введите число еще раз");
    }
    if (count == 4)
    {
        Console.WriteLine("введите первое число: ");
        int pervoe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число: ");
        int vtoroe = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(pervoe / vtoroe);
        Console.WriteLine("введите число еще раз");
    }
    if (count == 5)
    {
        Console.WriteLine("введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите желаемую степень: ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int v = 1; v < b; v++)
            a <<= 1;
        Console.WriteLine(a);
        Console.WriteLine("введите число еще раз");
    }
    if (count == 6)
    {
        Console.WriteLine("введите первое число: ");
        int pervoe = Convert.ToInt32(Console.ReadLine());
        double res = Math.Sqrt(pervoe);
        Console.WriteLine(res);
        Console.WriteLine("введите число еще раз");
    }
    if (count == 7)
    {
        Console.WriteLine(" введите число чтобы узнать его 1 процент");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a / 100);
        Console.WriteLine("введите число еще раз: ");

    }
    if (count == 8)
    {
        Console.WriteLine("введите число чтобы узнать его факториал: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 1;
        for (int k = 2; k <= a; k++)
        {
            b = b * k;
        }
        Console.WriteLine(b);
    }
}
