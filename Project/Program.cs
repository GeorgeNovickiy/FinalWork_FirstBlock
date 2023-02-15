string[] CreateArrayString() // Метод создания массива
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size]; // по умолчанию создается массив размером size, заполненный нулями.

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] CopyArray(string[] arr)
{
    string[] tempArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) tempArray[i] = arr[i];
    }
    return tempArray;
}

