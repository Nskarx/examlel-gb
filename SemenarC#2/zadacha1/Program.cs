﻿// цикл это повторяющаясяя последовательность действий (for- счетный цикл foreach /while -Условный цикл      do.while  )

//Prog1
//for(int i = 1; i < 10; i++) // либо i = i+i или i+=i
//{
     //Console.WriteLine($"{i + 10} - я всегда прав");
//}

//Prog2

//int k = 0;
//while(k < 10 || k < 20)  // || -or(или)  &&-end
//{
   //  k += 2;
    //if(k == 8)
   // {
     // break;  //   continue это переход от сюда в начало break; - окончание
    //}
    
    // Console.WriteLine($"{k} - я всегда прав ");
//}

//prog3

// int i = -1; // int-целое число
// Console.WriteLine(i);
// int result = Math.Abs(i);  // математическая функция , абс(модуль числа,абсолютное значение числа)
// Console.WriteLine(result);

// prog4

// int i = -1;
// int j =  3;
// //Console.WriteLine(i);
// int result = Math.Max(i,j);  //математическая функция -максимальное число
// Console.WriteLine(result);

//prog5

// double i = -1.56789; // double- дробное число число
// Console.WriteLine(i);
// double result = Math.Round(i, 2);//round -функция округления
// Console.WriteLine(result);

//Program 6

// int i = new Random().Next(1, 3);// генерация случайного числа (1, после запятой поставленное число не будет выводиться)
// Console.WriteLine(i);

//program7

//напишите программу,которая выводит случайное число из отрезка [10,99] и показывает наибольшии цифру числа
// 78->8
// 12->2
// 85->8
int num = new Random().Next(10, 99); // деление с целыми числами
Console.WriteLine(num);
int n1 = num / 10; // деление
int n2 = num % 10; // остаток от деления, то что не делиться на десять количество десятков
if(n1 > n2) Console.WriteLine(n1);   // сравнение
else Console.WriteLine(n2);

// 11.
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98