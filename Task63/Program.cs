// Задача №63: Задайте значение N.Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N

void ShowNumbers(int numberN)
{
    Console.Write(numberN + " ");
    if (numberN > 1) ShowNumbers(numberN - 1);
}
ShowNumbers(7);

/* void number (int num)
 {
    if (num > 0)
     {
        Console.Write(num);
        num -= 1;
        number(num);
    }
       else return;
 }
    int num = 5;
    number(num);
    */