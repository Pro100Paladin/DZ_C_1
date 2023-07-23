// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
// вариант 1 [хитрый]
Console.WriteLine("Введите целое число ");
    int number = int.Parse(Console.ReadLine()!);
    int number2 = 2;
    while (number2 <= number)
            
    {
        Console.Write($"{number2} ");
        number2+=2;
    }

*/

// вариант 2 [правельный]

Console.WriteLine("Введите целое число ");
int number = int.Parse(Console.ReadLine()!);
int number2 = 1;
    while (number2 <= number) 
    { 
        if (number2 % 2 == 0)
        Console.Write($"{number2}, ");
        number2++;
    }




