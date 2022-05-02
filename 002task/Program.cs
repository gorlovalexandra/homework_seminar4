/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

void Sum(int N)
{
    int S = 0;
    while (N > 0 || N < 0)
    {
        int R = N % 10;
        S = S + R;
        N = N / 10;
    }
    Console.WriteLine(S);
}

Sum(-86359);
Console.WriteLine();
