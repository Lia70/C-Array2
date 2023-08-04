// Задача №55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае если это невозможно, программа должна вывести сообщение для пользователя

Console.Write("Enter count of the rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter count of the collumns: ");
int collumns = int.Parse(Console.ReadLine());
int [,] array = new int[rows, collumns];
InputRand(array);
ChangeRowCollumn(array);
ShowArray(array);

void ChangeRowCollumn(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
        return;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = temp;
        }
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void InputRand(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    ShowArray(array);
}