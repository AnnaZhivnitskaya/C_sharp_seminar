// 4. Задайте двумерный массив из целых чисел. Напишите программу,
//    которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void ChangeArray(int[,] array)
{
     int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++);

        
    }
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
Console.WriteLine();
ChangeArray(arr_1);
Print(arr_1);
//Console.WriteLine($"Element {num} located in the matrix - {FoundNum(arr_1, num)}");
