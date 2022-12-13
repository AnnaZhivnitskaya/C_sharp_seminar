// // 2. Задайте двумерный массив размера m на n,
//    каждый элемент в массиве находится по формуле: Aij = i + j.
//    Выведите полученный массив на экран.

int[,] MassNums(int row, int colomn) //создание функции, заполняющей массив
{
    int[,] arr = new int[row, colomn]; // создаем вспомогательный двумерный массив
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colomn; j++)

            arr[i, j] = i + j; // формула заполнения ячеек
    return arr; //возвращаем начение заполненного массива 
}
void Print(int[,] arr) // функция, выводящая на печать
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < colomn_size; j++)
            Console.Write($"{arr[i, j],4}|"); //числом указывается ширина столбцов
            Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Enter the number of rows: "); //задаем количество строк
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: "); // задаем количество столбцов
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row, column); // задаем рабочий массив, заполняемый функцией MassNums
                                        // с указанным количеством колонок и столбцов

Print(arr_1); // активируем функцию Print для массива arr_1