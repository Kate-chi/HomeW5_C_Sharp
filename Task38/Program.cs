/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным значениями элементов массива.

[3 7 22 2 78] -> 76
*/


int size = InputNum("Введите размер массива: ");
double[] array = new double[size];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным значением: {FindMax(array)} - {FindMin(array)} = {FindDiff(array)}");

double FindDiff(double[] arr)
{
    return Math.Round(FindMax(arr) - FindMin(arr), 2);
}

double FindMax(double[] arr)
{
    double max = arr[0];

    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];

    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);

        if(i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}