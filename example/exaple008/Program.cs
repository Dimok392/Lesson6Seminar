// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
//y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =9 -> (-0,5; -0,5)

// double k1 = 5;
// double k2 = 9;
// double b1 = 2;
// double b2 = 4;
// double x=(b2-b1)/(k1-k2);
// double y1 =  k1 *x + b1;
// double y2 =  k2 *x + b2;
// Console.WriteLine(x);
// Console.WriteLine(y1);
// Console.WriteLine(y2);


// double k1 = 5;
// double k2 = 9;
// double b1 = 2;
// double b2 = 4;
// double y1 ;
// double y2 ;
// double x1 = -20;
// double x2 = 41;
// while(x1<x2)
// {
// y1 =  k1 *x1 + b1;
// y2 =  k2 *x1 + b2;
// if (y1==y2)
// {
//     Console.WriteLine(x1);
//     Console.WriteLine(y1);
// }
// x1 = x1+0.25;
// }
double k1 = 5;
double k2 = 9;
double b1 = 2;
double b2 = 4;
double x=(b2-b1)/(k1-k2);
double y=0;
double Function (double x, double k1, double b1)
{
   double y = k1*x + b1;
return y;
}
void Print(double y)
{
 Console.Write(y+" ");
}
Function(x,k1,b1);
Print(y);
