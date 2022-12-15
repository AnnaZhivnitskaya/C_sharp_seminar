//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

string FoundNum(int[,] array)
{
    Console.Write("Введите первую позицию элемента: ");
    int k = int.Parse(Console.ReadLine()!);
    Console.Write("Введите вторую позицию элемента: ");
    int n = int.Parse(Console.ReadLine()!);

    int row1 = array.GetLength(0);
    int column1 = array.GetLength(1);

    for (int i = 0; i < row1; i++)
        for (int j = 0; j < column1; j++)
        {
            if (i == k - 1 && j == n - 1)
                return $"{array[i, j]}";
        }
    return "такого элемента нет";
}

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));
Print(arr_1);

Console.WriteLine($"Значение элемента с заданными позициями: {FoundNum(arr_1)}");