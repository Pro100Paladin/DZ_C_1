// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("введите число");
int number1 = int.Parse(Console.ReadLine()!);
int chet = number1%2;
    if (chet == 0)
Console.WriteLine("Да");
    else
Console.WriteLine("Нет");



