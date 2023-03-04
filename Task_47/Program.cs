/* 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] Create_array ()
{
    Console.Write("input count rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min value: ");
    int min_value = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max value: ");
    int max_value = Convert.ToInt32(Console.ReadLine());

    double [,] new_array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            new_array[i, j] = Math.Round(
            (new Random().Next(min_value, max_value)) + 
            (new Random().NextDouble()), 1);
        }
    }
    return new_array;
}

void Show_array (double [,] show_array)
{
    for (int i = 0; i < show_array.GetLength(0); i++)
    {
        for (int j = 0; j < show_array.GetLength(1); j++)
        {
            Console.Write(show_array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Show_array(Create_array());