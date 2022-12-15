// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

int[] Fill(int length, int from, int to) // создаем функ заполнения массива
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}


void Print(int[] print) // создаем функ печати массива
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

string Find(int[] find, int num)
{

    for (int i = 0; i < find.Length; i++)

        if (find[i] == num)
        {
            return "yes";
        }
    return "no";
}

int[] collection = Fill(int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));

Print(collection);

Console.WriteLine(Find(collection, int.Parse(Console.ReadLine()!)));
