// цикл это повторяющаясяя последовательность действий (for- счетный цикл foreach /while -Условный цикл      do.while  )

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
// int num = new Random().Next(100, 1000); // деление с целыми числами
// Console.WriteLine(num);
// int n1 = num / 10; // деление
// int n2 = num % 10; // остаток от деления, то что не делиться на десять количество десятков
// if(n1 > n2) Console.WriteLine(n1);   // сравнение
// else Console.WriteLine(n2);

// program 8
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
// int num = new Random().Next(100, 1000);
// int c = num % 10;
// int a = num / 100;
// Console.WriteLine(num);
// int ac = a*10+c;
// Console.WriteLine(ac);


// program 9

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите 1 число: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2 число: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());
//  if(num1 % num2 == 0) Console.WriteLine("кратно: ");
//  else Console.WriteLine($" не кратно, остаток от деления = {num1 % num2}");

// program 10

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите  число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// if(n1 % 7 == 0 && n1 % 23 == 0)
// Console.WriteLine($"{n1} кратно 7 и 23 ");
// else Console.WriteLine($"{n1}  не кратно 7 и 23 ");

// program 11

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
// Console.Write("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine()); 
// if(n1 * n1 == n2)
//  Console.Write($"{n1} является квадратом {n2}: ");
// else
//  Console.Write($"{n1} не является квадратом {n2}: ");

     
     

 