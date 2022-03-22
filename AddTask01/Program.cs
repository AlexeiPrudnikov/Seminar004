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
string BinNumber (int number)
{
    string result = "";
    string temp = "";
    do
    {
        temp += (number % 2);
        number /= 2;
    }
    while (number > 0);
    char[] array = temp.ToCharArray();
    Array.Reverse(array);
    result = new string(array);
    return result;
}

bool IsPolindrom(string str)
{
    bool result = false;
    for (int i = 0; i < str.Length / 2; i ++)
    {
        if (str[i] == str[str.Length - i - 1 ])
        {
            result = true;
        }
        else
        {
            result = false;
            break;
        }
    }
    return result;
}

Console.WriteLine("==========Дополнительная задача № 1==========");
Console.WriteLine("На вход подается натуральное число. Прверить, является ли оно полиндромом в двоичном виде");
int number = 0;
Console.Write("Введите натуральное число: ");
do
{
    number = EnterNaturalNumber();
}
while (number <= 0);
string binNumber = BinNumber(number);
Console.WriteLine(binNumber);

Console.Write($"Двоичная запись числа {number} ");
if (!IsPolindrom(binNumber)) Console.Write("НЕ ");
Console.WriteLine("является полиндромом.");
