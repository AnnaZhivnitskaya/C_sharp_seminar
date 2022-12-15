//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] collection = new int[8];

void NumArray(int[] collection)
{
    for (int index = 0; index < 8; index++)
    {
        collection[index] = new Random().Next(1, 100);
        Console.Write(collection[index] + " ");
    }
    Console.WriteLine("\r");
}
NumArray(collection);
