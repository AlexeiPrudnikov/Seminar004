const int arrayLenght = 100;
const int maxValue = 99;
void GenArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, maxValue + 1);
    }
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }    
    Console.WriteLine();
}
int[] GetStatElements(int[] array)
{
    int[] result = new int[maxValue + 1];
    for (int i = 0; i < array.Length; i++)
    {
        result[array[i]]++;
    }
    return result;
}
void MaxElements(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == max) Console.WriteLine($"Наиболее часто встречается {i}");
    }
}
Console.WriteLine("==========Дополнительная задача № 3==========");
Console.WriteLine("Массив из 100 элементов задается случайными числами от 1 до 99. Определить самый часто встречающийся элемент в массиве.");
int[] array = new int[arrayLenght];
GenArray(array);
PrintArray(array);
int[] stat = GetStatElements(array);
stat = GetStatElements(array);
MaxElements(stat);


