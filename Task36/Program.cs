/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int min = -20;
int max = 20;

int size = InputNum("Введите размер массива: ");
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write($"Сумма элементов, стоящих на нечетных позициях = {UnevenSum(array)}");

int UnevenSum(int[] arr)
{
    int sum = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] arr)
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