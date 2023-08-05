// Задача №69: Напишите программу, которая на вход принимает два числа А и В
// и возводит число А в целую степень В в рекурсии
// 2^(-1)=1/2;
// 2^(-3)=1/(2^3)=1/8  2^3=8
// -2^(-3)=-1/(2^3)   -2^3=-8    -2^4=16
// 2^0=1     18888^0=1
/* b > 0 *= a b раз
   b < 0 1/= a b раз
   b = 0 return 1.0;
*/
double FindPower(int a, int b)
{
    if (b > 0) return FindPower(a, b - 1) *a;
    if (b < 0) return FindPower(a, b + 1) /a;
    return 1.0;
}
double resultFind = FindPower(2, -4);
Console.Write(resultFind);
