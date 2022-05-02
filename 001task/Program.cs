/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

void IfNegative(double A, double B)
{
    double res = 0;

    if (A > 0 && B > 0)
    {
        res = Math.Pow(A, B);
    }
    if (A < 0 && B < 0)
    {
        res = Math.Pow(A, (B * -1));
    }
    if (A > 0 && B < 0)
    {
        res = Math.Pow(A, (B * -1));
    }
    if (A < 0 && B > 0)
    {
        res = Math.Pow(A, B);
    }

    Console.WriteLine(res);
}

IfNegative(-2, -5);
Console.WriteLine();
