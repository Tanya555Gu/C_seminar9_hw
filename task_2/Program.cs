// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string messege)
{
    Console.Write($"{messege} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalNumbers(int M, int N)
{
    if (M > N)
    {
        return 0;
    }

    return M + SumNaturalNumbers(M + 1, N);
}

int M = ReadInt("Введине нижнюю границу интервала");
int N = ReadInt("Введине верхнюю границу интервала");
System.Console.WriteLine(SumNaturalNumbers(M, N));