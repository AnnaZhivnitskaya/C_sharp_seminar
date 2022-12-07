// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] Array(int sum, int from, int to)
{
    int[] arr = new int[sum];
    for (int i = 0; i < sum; i++)
    {
        i = new Random().Next(0, 100);
    }
    return arr;
}

void Print(int[] array)

{
    int dlin = array.Length;
    
    for(int i = 0; i < dlin; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int InRange(int[] arr)
{   
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)        
            n += 1;          
    }
    return n;    
}

int[] collection = Array(int.Parse(Console.ReadLine()!),
                       int.Parse(Console.ReadLine()!),
                       int.Parse(Console.ReadLine()!));

Print(collection);
Console.WriteLine(InRange(collection));