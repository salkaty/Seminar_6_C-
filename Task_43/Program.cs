// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
System.Console.WriteLine("Введите K1");
int numK1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите K2");
int numK2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите B1");
int numB1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите B2");
int numB2 = Convert.ToInt32(Console.ReadLine());

double numX=(numB2-numB2)/(numK1-numK2);
double numY=numK1*numX+numB1;
 System.Console.WriteLine($"Точка пересесения двух прямых имеет координаты X - {numX}");
System.Console.WriteLine($"Точка пересесения двух прямых имеет координаты Y - {numY}");

