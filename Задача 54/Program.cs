// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

Console.WriteLine("Введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[line, column];
FillArrayRandomNum(num);
Console.WriteLine("Массив до изменения");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(num);
Console.ResetColor();


for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < num.GetLength(1) - 1; z++)
        {
            if (num[i, z] < num[i, z + 1])
            {
                int temp = 0;
                temp = num[i, z];
                num[i, z] = num[i, z + 1];
                num[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Массив с упорядоченными значениями");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(num);
Console.ResetColor();

void FillArrayRandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("");
        Console.WriteLine("");
    }
}