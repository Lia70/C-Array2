// Задача №51: Задайте двумерный массив. Найдите сумму элементов, находящейся на главной диагонали
// (с индексами (0,0); (1,1)) и т.д.
// Н, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2=12
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    int sum_d = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i == j)
           sum_d += matrix[i, j];
        }
    }
    Console.WriteLine(sum_d);
}

Console.Write("Введите размеры матрицы: "); // 5,4...2,1
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("\n");
ReleaseMatrix(matrix);
