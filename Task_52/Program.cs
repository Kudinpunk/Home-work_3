/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("input count rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min value: ");
int min_value = Convert.ToInt32(Console.ReadLine());
Console.Write("input max value: ");
int max_value = Convert.ToInt32(Console.ReadLine());

int [,] Create_array (int size_rows, int size_columns, int min_val, int max_val)
{
    int [,] new_array = new int[size_rows, size_columns];
    for (int i = 0; i < size_rows; i++)
    {
        for (int j = 0; j < size_columns; j++)
        {
            new_array[i, j] = new Random().Next(min_val, max_val);
        }
    }
    return new_array;
}

void Arithmetical_mean_columns (int [,] new_show_array)

{
    for (int j = 0; j < new_show_array.GetLength(1); j++)
    {
        double result = 0;
        int n = 0;
        for (int i = 0; i < new_show_array.GetLength(0); i++)
        {
            result = (result + new_show_array[i, j]); 
            n += 1;
        }
        result = result / n;
        Console.Write(Math.Round(result, 1) + "; ");     
    }
}

void Show_array (int [,] new_show_array)
{
    for (int i = 0; i < new_show_array.GetLength(0); i++)
    {
        for (int j = 0; j < new_show_array.GetLength(1); j++)
        {
            Console.Write(new_show_array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int [,] user_array = Create_array(rows, columns, min_value, max_value);
Show_array(user_array);
Console.WriteLine();
Arithmetical_mean_columns(user_array);