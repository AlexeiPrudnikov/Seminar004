void GenArray(int[] array, int absValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1 * Math.Abs(absValue), Math.Abs(absValue) + 1);
    }
}
void PrintArray (int[] array)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SortUpArray(int[] array)
{
    int minIndex = 0;
    int temp = 0;
    for (int i = 0; i < (array.Length - 1); i++)
    {
        minIndex = i;
        for (int j = i; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < (Math.Abs(array[minIndex]))) minIndex = j;
        }
        if (minIndex != i)
        {
            temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}
void SortDownArray(int[] array)
{
    int maxIndex = 0;
    int temp = 0;
    for (int i = 0; i < (array.Length - 1); i++)
    {
        maxIndex = i;
        for (int j = i; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) > (Math.Abs(array[maxIndex]))) maxIndex = j;
        }
        if (maxIndex != i)
        {
            temp = array[i];
            array[i] = array[maxIndex];
            array[maxIndex] = temp;
        }
    }
}
Console.WriteLine("==========Задача № 29==========");
Console.WriteLine("Напишите программу, которая задает массив из 8 случайных элементов и возвращщает отсортированный по модулю массив");
const int arrayLenght = 8;
const int absValue = 20;
int[] array = new int[arrayLenght];
GenArray(array, absValue);
PrintArray(array);
SortUpArray(array);
Console.WriteLine("Сортировка по возрастанию");
PrintArray(array);
Console.WriteLine("Сортировка по убыванию");
SortDownArray(array);
PrintArray(array);
