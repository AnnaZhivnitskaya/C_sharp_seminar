// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void MaxSumRow(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    int minRowSum = int.MaxValue;
    int numMinRow = 0;

    for (int i = 0; i < row; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < column; j++)
            rowSum += array[i, j];

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            numMinRow = i + 1;
        }
    }
    Console.WriteLine($"Строка {numMinRow} с минимальной суммой элементов {minRowSum}");
    Console.WriteLine();
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

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));

Print(arr_1);
MaxSumRow(arr_1);

