// Задача №67: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N
// M < N; M = N; M > N

void ShowNumbersMN (int numM, int numN)
{
   // Math.Min(numM, numN)
   Console.Write($"{Math.Min(numN, numM)}");
   if (Math.Min(numM, numN) != Math.Max(numM, numN)) ShowNumbersMN (Math.Min(numM, numN)+1, Math.Max(numM, numN));

}
ShowNumbersMN(5, 9);