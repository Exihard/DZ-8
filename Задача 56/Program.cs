// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[line, column];
FillArrayRandomNum(num);
PrintArray(num);
int min = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + num[i, j];        
    }
    if (sum < min)
    {
        min = sum;
        indexLine++;
    }
}
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Строка с наименьшей суммой элементов под номером: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(indexLine);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(", её сумма элементов равна: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{min}");
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}