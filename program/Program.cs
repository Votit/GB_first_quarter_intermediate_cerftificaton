string[] CreateArray()
{
    Console.Write("Введите размер массива: ");
    int n = int.Parse(Console.ReadLine());
    string[] array = new string[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку № {i + 1}: ");
        array[i] = Console.ReadLine();
    }

    return array;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        foreach (string str in array)
        {
            Console.WriteLine(str);
        }
    }
}

string[] CreateNewReducedArray(string[] array)
{
    int[] indexesStringLengthLessThreeSymbols = new int[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            indexesStringLengthLessThreeSymbols[count] = i;
            count++;
        }
    }

    string[] newArray = new string[count];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[indexesStringLengthLessThreeSymbols[i]];
    }

    return newArray;
}


string[] arrayOfStrings = CreateArray();
PrintArray(CreateNewReducedArray(arrayOfStrings));