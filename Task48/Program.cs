// Задача №48: Задайте двумерный массив, размером m на n, в массиве
// каждый элемент находится по формуле: A(mn) = m + n. Выведите полученыый массив на экран

void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // matrix[i, j] = new Random().Next(0, 1000);
            matrix [i, j] = i + j;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размеры матрицы: "); // 5,4...2,1
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);