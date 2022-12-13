// Задача 62: Заполнить спирально массив 4 на 4.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"0{array[i, j]} ");
                Console.ResetColor();
            }
            else
                if (array[i, j] > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(array[i, j] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(array[i, j] + " ");
                    Console.ResetColor(); 
                }
        }
        Console.WriteLine("");
    }
}