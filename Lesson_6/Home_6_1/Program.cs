// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите любое количество чисел в отрицательном и положительном диапазоне");


int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//cчитывает из консоли строку, разделяет её по пробелам, для каждой подстроки вызывает 
//int.Parse и приводит полученную коллекцию к типу массива.
//Select(x => int.Parse(x)) можно заменить на Select(int.Parse),

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) sum += 1;
}

Console.WriteLine(sum);

