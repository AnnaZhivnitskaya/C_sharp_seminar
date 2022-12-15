// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.


int[] FillArray(int nums, int from, int to) // создаем функ заполнения массива
{
    int[] arr = new int[nums];
    
    for(int i = 0; i < nums; i++)
    
        arr[i] = new Random().Next(from, to);
        return arr;
    
}                                         


void PrintArray(int[] print) // создаем функ печати массива
{
    int ind = 0;
    int count = print.Length;
    while (ind < count)
    {
        Console.Write(print[ind] + " ");
        ind++;
    }
    Console.WriteLine();
}

void Change(int[] exchange) // созд функ смены знака
{
    for(int i = 0; i < exchange.Length; i++)
    exchange[i] = exchange[i] * (-1);
}

int[] collection = FillArray(int.Parse(Console.ReadLine()!),
                       int.Parse(Console.ReadLine()!),
                       int.Parse(Console.ReadLine()!)); //создаем массив, с которыми будут работать функции


PrintArray(collection);
Change(collection);
PrintArray(collection);