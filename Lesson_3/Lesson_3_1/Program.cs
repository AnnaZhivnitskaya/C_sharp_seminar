//  Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");

int numQuatro = int.Parse(Console.ReadLine()!);

    if(numQuatro == 1)
        Console.WriteLine("x > 0, y > 0");
     else if(numQuatro == 2)
        Console.WriteLine("x < 0, y > 0");
     else if(numQuatro == 3)
        Console.WriteLine("x < 0, y < 0");
     else if(numQuatro == 4)
        Console.WriteLine("x > 0, y < 0");
