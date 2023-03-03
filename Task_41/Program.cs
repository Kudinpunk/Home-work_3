/*
 Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

int [] Input_user_array (int count_numbers)
{
    int [] user_array = new int[count_numbers];
    for (int i = 0; i < count_numbers; i++)
    {
        user_array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return user_array;
}

void Show_user_array (int [] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        Console.Write(new_array[i] + ", ");
    }
}

int Count_negativ_numbers (int [] array)
{
    int result = 0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                result +=1;
        }
    }    
    return result;
}

Console.Write("Input count of numbers: ");
int count_numbers = Convert.ToInt32(Console.ReadLine());
int [] user_array = Input_user_array(count_numbers);
Show_user_array(user_array);
Console.Write("\b\b -> ");
Console.Write(Count_negativ_numbers(user_array));
