// console.Write("Введите а");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b");
// int b = Convert.ToInt32(Console.ReadLine());
// double c = Math.Sqrt(a);
// Console.WriteLine(c);

// string name1 = "bob";
// string name2 = "ann";
// string name3 = "Jon";
// string name4 = "Liz";

// string[]friends = {"bob","ann","Jon","Liz"};// 0, 1, 2, 3
// int[]age ={20, 19, 27,35};
// // int [] age = new int [4];
// Console.WriteLine(friends[3]);
// friends[3] = "Liza";
// Console.WriteLine(friends.Length);

// // for(int i = 1; i < age.Length; i++)
// foreach (int i in age)
// {
//     // age[i] = age[i] -10;
//     // Console.WriteLine(age[i]);
//     Console.WriteLine(i);
// }

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// 18) Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// 21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// 22) Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.WriteLine("Введите координаты x ");
// int x = Convert.ToInt32(Console.ReadLine());
// while (x == 0)
// {
//     Console.WriteLine("Введите не нулевое значение x ");
//     x = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Введите координаты y ");
// int y = Convert.ToInt32(Console.ReadLine());
// while (y == 0)
// {
//     Console.WriteLine("Введите не нулевое значение y ");
//     y = Convert.ToInt32(Console.ReadLine());
// }

// if (x > 0)
//     if (y > 0)
//         Console.WriteLine("Правая верхняя");
//     else
//         Console.WriteLine("Правая нижняя");
// else
//     if (y > 0)
//         Console.WriteLine("Левая верхняя");
//     else
//         Console.WriteLine("Левая нижняя");


//  18) Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x и y)
// Console.WriteLine("Введите номер четверти от 1 до 4");				
// int T = Convert.ToInt32(Console.ReadLine());


// while (T<0 || T>4)
// {
//     Console.WriteLine("Введите правильный номер четверти");
        // T = Convert.ToInt32(Console.ReadLine());
// }

// if (T==1)
// Console.WriteLine("Значения X и Y положительные");
// else if (T==2)
// Console.WriteLine("Значение X отрицательное, а Y - положительное");
// else if (T==3)
// Console.WriteLine("Значения X и Y отрицательные");
// else
// Console.WriteLine("Значение X положительное, а Y - отрицательное");


// 21) Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2
// Console.WriteLine("Введите координаты x первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты x второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double ab = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

// Console.WriteLine(Math.Round(ab,3));

// 22) Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число до которого будет идти таблица");
int N = Convert.ToInt32(Console.ReadLine());
while (N == 0)
{
    Console.WriteLine("Неверный ввод, введите снова не нулевое число");
    N = Convert.ToInt32(Console.ReadLine()); 
}

if (N>0)
    for (int i = 1; i <= Math.Abs(N); i++)
    {
        Console.WriteLine($"Квадрат {i}: {Math.Pow(i, 2)}");
    }
else
    for (int i = 1; i >= N; i--)
    {
        Console.WriteLine($"Квадрат {i}: {Math.Pow(i, 2)}");
    }




