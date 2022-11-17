/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int min = 100;
int max = 999;

int size = InputNum("Введите размер массива: ");
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write($"В массиве {FindEven(array)} четных чисел");


int FindEven(int[] arr)
{
    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
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