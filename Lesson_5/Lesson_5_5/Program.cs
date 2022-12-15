// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.

int[] Arrey(int num, int from, int to)
{
    int[] mass = new int[num];
    for (int i = 0; i < num; i++)
    {
        mass[i] = new Random().Next(from, to);
    }
    return mass;
}

void Print(int[] count)
{
    int begin = count.Length;
    for (int i = 0; i < begin; i++)
    {
        Console.Write($"{count[i]} ");
    }
    Console.WriteLine();
}

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_arr[i] = arr[i] * arr[size - i - 1];

    if (new_arr[flex_size - 1] == 0)
        new_arr[flex_size - 1] = arr[flex_size - 1];
    return new_arr;
}

int[] arr_1 = Arrey(int.Parse(Console.ReadLine()!),
                       int.Parse(Console.ReadLine()!),
                       int.Parse(Console.ReadLine()!));
Print(arr_1);
int[] arr_1_new = PairsNum(arr_1);
Print(arr_1_new);