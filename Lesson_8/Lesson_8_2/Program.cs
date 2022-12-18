// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)

        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(from, to);
    return array;
}

void ChangeRowColumn(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row != column)
    {
        Console.WriteLine("Действие невозможно");
    }
    else
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)// здесь j < i, чтобы не дать пройти по кругу
            {
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);// здесь меняем строки и столбцы
            }
            Console.WriteLine();
        }
    }
}


void PrintArray(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = FillArray(row, column,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));
PrintArray(arr_1);
ChangeRowColumn(arr_1);
PrintArray(arr_1);

