int EnterNaturalNumber()
{
    try
    {
        int n = 0;
        do
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) Console.Write("Ошибка ввода, число должно быть натуральным. Введите натуральное число: ");
        }
        while (n <= 0);
        return n;
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        return -1;
    }
}
long Power (int a, int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}
int a = 0; // основние степени
int n = 0; // показатель степени
Console.WriteLine("==========Задача № 25==========");
Console.WriteLine("Напишите цикл, который принимает на вход числа a и n, а потом возводит число a в степень n");
try
{
    Console.Write("Введите основание степени: ");
    do
    {
        a = EnterNaturalNumber();
        if (a < 0) Console.Write("Ошибка ввода, введите основание степени: ");
    }
    while (a <= 0);
        Console.Write("Введите показатель степени: ");
    do
    {
        n = EnterNaturalNumber();
        if (n < 0) Console.Write("Ошибка ввода, введите основание степени: ");
    }
    while (n <= 0);
    Console.WriteLine($"Число {a} в степени {n} равно {Power(a, n)}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}