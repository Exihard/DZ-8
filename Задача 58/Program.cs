// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Input(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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

int size = Input("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNum(matrixA);
FillArrayRandomNum(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

Console.WriteLine("Матрица - А");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(matrixA);
Console.ResetColor();
Console.WriteLine("Матрица - В");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(matrixB);
Console.ResetColor();
Console.WriteLine("Произведение матриц А*В");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(matrixC);
Console.ResetColor();