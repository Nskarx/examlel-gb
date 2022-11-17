// // Напишите программу,которая на вход принимает два числа и проверяет,являеться ли первое число квадратом второго
// // a = 25, b = 5-> yes
// // a = 2, b = 10-> no
// // a = 9, b = -3 -> yes
// // a = -3 , b = 9-> no

// Console.Write("Введите 1 число: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите 2 число: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2)
// { 
//     Console.Write("Числа равны: ");
// }
// else if(num1 == num2 * num2)
// {
//     Console.Write("Числа в квадрате: ");
// }
// else if(num1 == num2 * num2 * num2)
// {
//     Console.Write("Числа в кубе: ");
// }
// else
// {
//     Console.Write("Числа не равны: ");
// }

// напишите программу,которая будет выдавать название дня недели по заданному номеру.
// 3-> среда
// 5 -> пятница

Console.WriteLine("Введите номер дня недели");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("понедельник");
}
else if (num1 == 2)
{
    Console.WriteLine("Вторник");
}
else if (num1 == 3)
{
    Console.WriteLine("Среда");
}
else if (num1 == 4)
{
    Console.WriteLine("Четверг");
}
else if (num1 == 5)
{
    Console.WriteLine("Пятница");
}
else if (num1 == 6)
{
    Console.WriteLine("Суббота");
}
else if (num1 == 7)
{
    Console.WriteLine("Воскресенье");
}