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