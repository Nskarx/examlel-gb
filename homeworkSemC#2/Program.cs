
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Write("Введите число: ");
// int num =  Convert.ToInt32(Console.ReadLine());
// int a = num / 10;
// int c = num % 100;
// int ac = c%10;
// Console.WriteLine(ac);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите число от 1 до 7:  ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
    else Console.WriteLine("Сегодня рабочий день");
}

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 
//
// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
//  num = num / 10 % 10;
// Console.WriteLine($"{num}");
//
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Write("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numStr = Convert.ToString(num);
//  int numDigit = numStr.Length;
// if (numDigit > 2) Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
// else Console.WriteLine("третьей цифры нет");