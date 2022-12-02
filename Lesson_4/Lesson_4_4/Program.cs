// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

int[] collection = new int[8];

void FillArray(int[] collection)
{
    int index = 0;
    while (index < 8)
    {
        collection[index] = new Random().Next(2);
        
        Console.Write($"{collection[index]}, ");

        index++;
        
    }
}
FillArray(collection);