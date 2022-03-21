int GetSumDigits(int number)
{
    int sum = 0;
    number = Math.Abs(number);
    do
    {
        sum = sum + (number % 10);
        number /= 10;
    }
    while (number > 0);
    return sum;
}
Console.WriteLine("==========Задача № 27==========");
Console.WriteLine("Напишите программу, которая принимает на вход число, а потом возвращает сумму цифр в числе");
int number = 0;
try
{
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ($"Сумма цифр числа {number} равна {GetSumDigits(number)}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}