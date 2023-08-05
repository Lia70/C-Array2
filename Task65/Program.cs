// Задача №65: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр

int SumDigits (int num)
{
    if (num < 0) num *= -1;
    if (num > 0) return SumDigits (num / 10) + num % 10; 
    else return 0;
}
int res = SumDigits(-859);
Console.Write(res);
