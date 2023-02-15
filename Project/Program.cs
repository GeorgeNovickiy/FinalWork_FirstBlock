﻿string[] CreateArrayString() // Метод создания массива
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size]; // по умолчанию создается массив размером size, заполненный нулями.

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}