// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

Console.WriteLine("Введите первое число ");
int first = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int second = int.Parse(Console.ReadLine()!);  

string Res(int first, int second)//задаем string в качестве выходного типа данных, т.к.
//на выходе у return текстовые значения.
{
if (first % second == 0)
    return ("кратно");

else //(first % second > 0)
    return ($"не кратно, {first % second}");// $ указывает на то, что это 
//самая строка будет той самой, куда можно подставить переменные напрямую
}
Console.WriteLine(Res(first, second));
