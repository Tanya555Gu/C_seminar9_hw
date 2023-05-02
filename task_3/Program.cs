// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int PrintAcker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return PrintAcker(m - 1, 1);
    }
    else
    {
        return PrintAcker(m - 1, PrintAcker(m, n - 1));
    }
}

System.Console.WriteLine(PrintAcker(3, 2));