//программа принимает 2 неотрицательных числа m и n 
//и выводит значение функции Аккермана для этих 2 чисел

int AkkermanFunction(int m, int n)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0 && n > 0)
    {
        return AkkermanFunction(1, n - 1);
    }
    if (m > 0 && n > 0)
    {
        return AkkermanFunction(AkkermanFunction(m - 1, n), n - 1);
    }

    return AkkermanFunction(m, n);
}

Console.WriteLine(AkkermanFunction(3, 2));