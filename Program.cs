// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
/*
int number1, result = 0;
    bool neg = false;
 
    Console.Write("enter number: ");
    number1 = Int32.Parse(Console.ReadLine());
    int number2 = number1;
 
    while(number1 > 0){
        result *= 10;
        result += number1 % 10;
        number1 /= 10;
    }
 
if (result == number2) Console.WriteLine("да");
else 
{
    Console.WriteLine("нет");
}

*/
//-----------------------------------------------------------------------


// Задача 2: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));
}
Console.Write("введите координаты первой точки х: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты первой точки y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты первой точки z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты второй точки x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты второй точки y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты второй точки z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Длина отрезка: " + Math.Round(Length(x1, y1, z1, x2, y2, z2), 2));
*/

//-------------------------------------------------------------------------------

//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void PrintKub(int n)
// {
//     int i = 1;
//     while (i <= n)
//     {
//         Console.Write(Math.Pow(i,3) + " ");
//         i++;
//     }
// }
// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// PrintKub(n);
//---------------------------------------




