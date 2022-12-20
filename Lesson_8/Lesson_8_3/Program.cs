// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[] FrequencyDict(int[,] arr) // задаем 1-мерный массив, куда записываем значение того, сколько раз
{                               // число, соотв номеру индекса, встреч в 2-мерном массиве
    int[] freq = new int[10]; // кол-во элементов одномерн маасива

    foreach (int item in arr) // вводим переменную, которая из 2-мерного массива берет значение и 
    freq[item] += 1; // и в 1-мерный массив записывает, сколько раз это значение встречалось

    return freq; //на след итерации item затирается
}


void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)  // частный случай, длина массива 10, соотв индексов 10 (0 - 9)
        Console.WriteLine($"{i} meets: {arr[i]}"); // и значения заданы от 0 до 9 включ
    Console.WriteLine();
}

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
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
Print(arr_1); //при указании только названия, функция работает полностью для массива

int[] mass = FrequencyDict(arr_1); // вводим 1-мерный массив для функции FrequencyDict, принимающей
                                    //заданный 2-мерный массив arr_1
PrintMass(mass);