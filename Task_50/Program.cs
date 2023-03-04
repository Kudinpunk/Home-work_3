/* 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int [,] Create_array (int new_rows, int new_columns, int min_val, int max_val)
{
    int [,] new_array = new int[new_rows, new_columns];
    for (int i = 0; i < new_rows; i++)
    {
        for (int j = 0; j < new_columns; j++)
            new_array[i, j] = new Random().Next(min_val, max_val);
    }
    return new_array;
}

void Show_array (int [,] show_array)
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

Console.Write("input count rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input count columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input min value: ");
int min_value = Convert.ToInt32(Console.ReadLine());
Console.Write("input max value: ");
int max_value = Convert.ToInt32(Console.ReadLine());

int [,] user_array = Create_array (rows, columns, min_value, max_value);
Show_array(user_array);
Console.WriteLine();

void Find_for_index (int [,] new_end_array)

{
    Console.Write("input index of row(starting from the first): ");
    int user_row_index = Convert.ToInt32(Console.ReadLine());
    Console.Write("input index of column(starting from the first): ");
    int user_column_index = Convert.ToInt32(Console.ReadLine());

    if (user_row_index > rows | user_column_index > columns)
    {
        Console.WriteLine("There is no such number in the array.");
    }
    else
    {
        for (int i = 0; i < new_end_array.GetLength(0); i++)
        {
            for (int j = 0; j < new_end_array.GetLength(1); j++)
            {
                if (i == user_row_index - 1 & j == user_column_index - 1)
                {
                    Console.WriteLine($"Your number is {new_end_array[i, j]}.");
                }
            }
        }
    }
}

Find_for_index(user_array);
