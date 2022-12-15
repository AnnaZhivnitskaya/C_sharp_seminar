//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}                                         

int[] collection2 = new int[8];

void PrintArray(int[] collection2)
{
    int ind = 0;
    int count = collection2.Length;
    while (ind < count)
    {
        Console.Write(collection2[ind] + " ");
        ind++;
    }
    Console.WriteLine();
}
FillArray(collection2);
PrintArray(collection2);


//2 вариант

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(1, 100);
    return arr;
}

int[] arr_1 = EightMass(int.Parse(Console.ReadLine()!));
Print(arr_1);
