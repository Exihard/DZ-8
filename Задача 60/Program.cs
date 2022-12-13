// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите размерность X: ");
int lineX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность Y: ");
int lineY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность Z: ");
int lineZ = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[lineX, lineY, lineZ];
FillArray(array3D);
PrintIndex(array3D);

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.Write($"{array3D[i, j, k]} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"({i},{j},{k})  ");
                Console.ResetColor();
            }
        }
    }
}
