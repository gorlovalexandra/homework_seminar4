/* ОБЯЗАТЕЛЬНАЯ ЗАДАЧА: Найти сумму чисел от 1 до А. */

void Sum(int A)
{
    int S = 0;
    for (int i = 1; i <= A; i++)
    {
        S = S + i;
    }
    Console.WriteLine(S);
}

Sum(16);
Console.WriteLine();
