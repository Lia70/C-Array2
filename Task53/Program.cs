// Задача №53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами две любые строки местами

int[,] Creat2dArray(int rows, int collumns)
{
    int[,] createdArray = new int[rows, collumns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collumns; j++)
            createdArray[i, j] = new Random().Next(0, 10);
    return createdArray;
}

void ShowArray(int[,] showedArray)
{
    for (int i = 0; i < showedArray.GetLength(0); i++)
    {
        for (int j = 0; j < showedArray.GetLength(1); j++)
        {
            Console.Write(showedArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод для перестановки любых строк
void ChangeRows(int row1, int row2, int[,] arrayToChange)
{
    if (row1 >= 0
    && row1 < arrayToChange.GetLength(0)
    && row2 >= 0
    && row2 < arrayToChange.GetLength(0))
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            int temp = arrayToChange[row1, j];
            arrayToChange[row1, j] = arrayToChange[row2, j];
            arrayToChange[row2, j] = temp;
        }
        ShowArray(arrayToChange);
    }
    else
        Console.WriteLine("Error! Impossible value!");
}
Console.Write("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count of collumns: ");
int userCollumns = Convert.ToInt32(Console.ReadLine());

int[,] firstTaskArray = Creat2dArray(userRows, userCollumns);
ShowArray(firstTaskArray);

Console.Write("Enter number of the first row to remove: ");
int userRowFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of the second row to remove: ");
int userRowSecond = Convert.ToInt32(Console.ReadLine());
ChangeRows(userRowFirst, userRowSecond, firstTaskArray);
