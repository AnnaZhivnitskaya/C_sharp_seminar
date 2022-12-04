// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] collection = new int[8];

void NumArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        Console.Write(collection[index] + " ");
        
        index++;
    }
    Console.WriteLine("\r");
}

NumArray(collection);
