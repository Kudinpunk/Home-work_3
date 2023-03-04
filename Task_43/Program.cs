/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void Intersection_coordinates (double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double point_x = (b2 - b1) / (k1 - k2);
        double point_y = (point_x * k1) + b1;
        Console.WriteLine($"Intersection coordinates are x = {point_x}, y = {point_y}.");
    }
    else
        Console.WriteLine("Your lines are parallel.");
}

Console.Write("Input intersection point of first line: ");
int user_b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input slope of first line: ");
int user_k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input intersection point of second line: ");
int user_b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input slope of second line: ");
int user_k2 = Convert.ToInt32(Console.ReadLine());

Intersection_coordinates(user_b1, user_k1, user_b2, user_k2);
