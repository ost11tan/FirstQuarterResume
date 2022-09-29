string[] GetArray(int N)
{
    string[] result = new string[N];

    for (int i = 0; i < N; i++)
    {
        result[i] = Console.ReadLine();
    }

    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.Write("]");
}

int CountElementsArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] Sort(string[] arr)
{
    for (int k = arr.GetLength(0) - 1; k > 0; k--)
    {
        for (int i = 0; i < k; i++)
        {
            if (arr[i].Length > 3)
            {
                string temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }
    return arr;
}

string[] NewArray(string[] array)
{
    int size = CountElementsArray(array);
    Sort(array);
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i];
    }
    return result;
}

Console.WriteLine("Введите количество элементов массива:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите элементы массива по очереди:");

string[] myArray = GetArray(size);
PrintArray(myArray);

Console.WriteLine();
string[] myArrayNew = NewArray(myArray);
PrintArray(myArrayNew);
